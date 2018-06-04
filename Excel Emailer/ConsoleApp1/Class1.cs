using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeExcel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Net.Mail;
using Microsoft.Office.Interop.Excel;

namespace ConsoleApp1
{
    public class Class1
    {
        /// <summary>
        /// Function de collect DataTable from MySQL BDD into Dataset.
        /// </summary>
        /// <returns></returns>
        public static DataSet GetDataSet()
        {
            DataSet ds = new DataSet();
            System.Data.DataTable dtbl = new System.Data.DataTable();
            ////Define Columns
            //dtbl.Columns.Add("Heure & Date");
            //dtbl.Columns.Add("Numero Ticket");
            //dtbl.Columns.Add("Nom Client");
            //dtbl.Columns.Add("Adresse");
            //dtbl.Columns.Add("Nom Appelant");
            //dtbl.Columns.Add("Telephone");
            //dtbl.Columns.Add("Description de la panne");
            //dtbl.Columns.Add("Technicne Appelé");
            //dtbl.Columns.Add("Observations");

            dtbl = BDD.SelectDT("SELECT DATE_HEURE_APPEL,NUM_TICK_FRONT_OFFICE,NOM_CLIENT,ADRESSE,NOM_APPELANT,TELEPHONE_O,PANNE_DESC,TECH_APPELE,OBSERVATIONS FROM tbl_ineo_hno", "serdao");
            ds.Tables.Add(dtbl);


            //dtbl.Rows.Add("1",);//Adding Rows

            //dtbl.TableName = "Table1";

            //ds.Tables.Add(dtbl);

            //DataTable dtbl2 = dtbl.Copy();//Created copies of first table
            //dtbl2.TableName = "Table2";
            //ds.Tables.Add(dtbl2);


            return ds;
        }

        /// <summary>
        /// Function to export dataset to excel
        /// </summary>
        /// <param name="ds"></param>
        public static void ExportDataSetToExcel(DataSet ds, string strPath)
        {
            int inHeaderLength = 0, inColumn = 0, inRow = 0; //Declaration de int.


            System.Reflection.Missing Default = System.Reflection.Missing.Value;

            //Create Excel File
            strPath += @"Bilan des appels HNO " + DateTime.Now.ToString("dd-MM-yyyy_hh-mm") + ".xlsx";

            OfficeExcel.Application excelApp = new OfficeExcel.Application();
            OfficeExcel.Workbook excelWorkBook = excelApp.Workbooks.Add(1);
            excelApp.Visible = true;
            ds.Tables[0].Columns[0].ColumnName = "Date & Heure d'appel";
            ds.Tables[0].Columns[1].ColumnName = "Numéro de ticket.";
            ds.Tables[0].Columns[2].ColumnName = "Nom du Client";
            ds.Tables[0].Columns[3].ColumnName = "Adresse du Client";
            ds.Tables[0].Columns[4].ColumnName = "Nom de l'appelant";
            ds.Tables[0].Columns[5].ColumnName = "Numéro de téléphone";
            ds.Tables[0].Columns[6].ColumnName = "Description de la panne";
            ds.Tables[0].Columns[7].ColumnName = "Technicien Appelé";
            ds.Tables[0].Columns[8].ColumnName = "Observations";

            foreach (System.Data.DataTable dtbl in ds.Tables)
            {
                //Create Excel WorkSheet
                OfficeExcel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add(Default, excelWorkBook.Sheets[excelWorkBook.Sheets.Count], 1, Default);

                excelWorkSheet.Name = dtbl.TableName = "Resumé";//Name worksheet

                //Write Column Name
                for (int i = 0; i < dtbl.Columns.Count; i++)
                    excelWorkSheet.Cells[inHeaderLength + 1, i + 1] = dtbl.Columns[i].ColumnName.ToUpper();



                //Write Rows
                for (int m = 0; m < dtbl.Rows.Count; m++)
                {
                    for (int n = 0; n < dtbl.Columns.Count; n++)
                    {
                        inColumn = n + 1;
                        inRow = inHeaderLength + 2 + m;

                        excelWorkSheet.Cells.NumberFormat = "@"; // this allows us to keep the 0 at the start of our text elements!!!! important.


                        excelWorkSheet.Cells[inRow, inColumn] = dtbl.Rows[m].ItemArray[n].ToString();
                        if (m % 2 == 0)
                            excelWorkSheet.get_Range("A" + inRow.ToString(), "I" + inRow.ToString()).Interior.Color = System.Drawing.ColorTranslator.FromHtml("#FCE4D6");


                    }

                }
                //Excel Header

                Range line = (Range)excelWorkSheet.Rows[1];
                line.Insert();

                // Finding the last elements of my table :

                OfficeExcel.Range last = excelWorkSheet.Cells.SpecialCells(OfficeExcel.XlCellType.xlCellTypeLastCell, Type.Missing);
                OfficeExcel.Range range = excelWorkSheet.get_Range("A2", last);
                //this draws around the range area between A2 and the last element of the table.
                range.BorderAround(XlLineStyle.xlDouble);

                // Excel table style
                OfficeExcel.Range cellRang = excelWorkSheet.get_Range("B1", "H1");
                cellRang.Merge(true); // makes a single cell between B1 and H1 

                cellRang.Interior.Color = System.Drawing.Color.White;
                cellRang.Font.Color = System.Drawing.Color.Blue;
                cellRang.HorizontalAlignment = OfficeExcel.XlHAlign.xlHAlignCenter;
                cellRang.VerticalAlignment = OfficeExcel.XlVAlign.xlVAlignCenter;
                cellRang.Font.Size = 26;

                // this draws the borders of the excel document you selected.
                cellRang.BorderAround(XlLineStyle.xlDouble);

                //title of excel file
                excelWorkSheet.Cells[1, 2] = "Title of EXCEL FILE";



                //autofit errything together
                excelWorkSheet.Columns.AutoFit();




                ////optional if needed 
                ////[if you need it in an int]
                //int lastUsedRow = last.Row;
                //int lastUsedColumn = last.Column;
                //// using last elements of the table. 



                //Style table column names
                //cellRang = excelWorkSheet.get_Range("A4", "G4");
                //cellRang.Font.Bold = true;
                //cellRang.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                //cellRang.Interior.Color = System.Drawing.ColorTranslator.FromHtml("#ED7D31");
                //excelWorkSheet.get_Range("F4").EntireColumn.HorizontalAlignment = OfficeExcel.XlHAlign.xlHAlignRight;
                ////Formate price column
                //excelWorkSheet.get_Range("F5").EntireColumn.NumberFormat = "0.00";
                ////Auto fit columns
                //excelWorkSheet.Columns.AutoFit();
            }

            //Delete First Page
            excelApp.DisplayAlerts = false;
            Microsoft.Office.Interop.Excel.Worksheet lastWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkBook.Worksheets[1];
            lastWorkSheet.Delete(); // Efface la feuille Feuil1 d'excel.
            excelApp.DisplayAlerts = true;

            //Set Defualt Page
            (excelWorkBook.Sheets[1] as OfficeExcel._Worksheet).Activate();

            excelWorkBook.SaveAs(strPath, Default, Default, Default, false, Default, OfficeExcel.XlSaveAsAccessMode.xlNoChange, Default, Default, Default, Default, Default);
            excelWorkBook.Close();
            excelApp.Quit();

            Console.WriteLine("Excel generated successfully \n As " + strPath);
            return;

        }

        /// <summary>
        /// Creates and sends email to specific requested email.
        /// </summary>
        /// <param name="toAdress">Test email</param>
        /// <param name="subject">Test subject</param>
        /// <param name="body">body is a string... filled by html etc.</param>
        public static void CreateEmail(string toAdress, string subject, string strPath)
        {

            string result = "Message Sent Successfully!";

            string senderID = "tryotestvietalpha@gmail.com"; // use sender's e-mail id here...

            const string senderPassword = "NK;`3F8h]RZLH8pU"; // Sender password here...

            string body = "test";

            try
            {
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com", // smtp server adress here...
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new System.Net.NetworkCredential(senderID, senderPassword),
                    Timeout = 30000,

                };

                MailMessage message = new MailMessage(senderID, toAdress, subject, body);

                System.Net.Mail.Attachment attachment;

                attachment = new System.Net.Mail.Attachment(@"" + strPath);

                message.Attachments.Add(attachment);

                AlternateView plainView = AlternateView.CreateAlternateViewFromString(body, Encoding.UTF8, "text/plain");

                // We have something to show in real old mail clients.

                message.AlternateViews.Add(plainView);


                string Body = @"<html><head><title></title></head><body style='cursor:auto;'> 
    <h1> Dear user, thank you for working with us.</h1>
    <br/><u> underline text </u><br/>
    <strong> bold text </strong><br/>
    <em>italic text I wonder if I can put css here?</em><br/>
    <span style='font-size:14px'> Here is the <span style  'color:#B22222'> resumé </span> of our 
    <span style='background-color:#800000'> current </span> actions. </span>
    <ul><li> dots </li></ul> <ol><li>numbers</li><li>numbers</li></ol><blockquote>
    <p>Quotation</p></blockquote>
    <table border ='1' cellpadding ='1' cellspacing ='1' style ='width:500px' summary ='This is to show you how I coded a table. '>
    <caption> A table </caption><tbody><tr><td> Information </td><td> relative information </td></tr><tr>
    <td> it adapts depending on the text </td><td> so it doesn &#39;t look bad</td></tr> <tr>
     <td> Thank you very much </td> <td> Kind regards.</td> </tr>
     </tbody></table>    <br/> 
    <img alt='' src='http://itlaunchpad.blogs.uua.org/files/2011/09/3318_001-1024x564.jpg' style='height:54px; width:99px'/> &lt; =Image 
    <br/> <br/> Cheerio this is a link<br/><br/> <a href ='http://google.com' target ='_self' > And this is a link </a><br/>
    <br/> &copy; special characters<br/><br/>
    <iframe  frameborder='1' height='150' src='https://www.youtube.com/embed/fSLfw7Q93D8' width='300'>
    </iframe> special sized <br/>  &nbsp;</body> </html>";

                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(Body, Encoding.UTF8, "text/html");

                message.AlternateViews.Add(htmlView); // And a html attachment to make sure.

                // But the basis is the html body 

                message.IsBodyHtml = true; // But the basis is the html body

                message.Body = Body;


                Console.WriteLine("Attempting to Send Email");

                try
                {
                    smtp.Send(message);
                    Console.WriteLine("Email sent... ");
                }
                catch (System.Net.Mail.SmtpFailedRecipientException ex)
                {
                    Console.WriteLine("Could not send email to the mentioned recipient" + ex.Message);
                }
                catch (System.Net.Mail.SmtpException ex)
                {
                    Console.WriteLine("Could not send Email..\n" + ex.Message + "\n" + ex.StackTrace);
                }
                Console.WriteLine(result);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur : \n" + ex.Message);

            }


        }




    }
}
