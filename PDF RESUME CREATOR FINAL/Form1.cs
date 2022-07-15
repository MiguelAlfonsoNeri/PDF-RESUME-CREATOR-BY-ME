using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using System.IO;

namespace PDF_RESUME_CREATOR_FINAL
{
    public partial class Form1 : Form
    {
        private readonly string _fileName = @"C:\Users\Migo\OneDrive\Documents\Visual Studio 2022\try neri json\NERI_MIGUELALFONSO.json";
        public Form1()
        {
            InitializeComponent();
        }
        public class Resume
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string Surname { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public string AAddress { get; set; }
            public string BAddress { get; set; }
            public string ContactNumber{ get; set; }
            public string Objectives { get; set; }
            public string Askill { get; set; }
            public string Bskill { get; set; }
            public string Cskill { get; set; }
            public string Dskill { get; set; }
            public string Eskill { get; set; }
            public string Fskill { get; set; }
            public string Gskill { get; set; }
            public string Experience { get; set; }
            public string College { get; set; }
            public string SeniorHighSchool { get; set; }
            public string JuniorHighSchool { get; set; }
            public string Elementary{ get; set; }
            public string AAchievement{ get; set; }
            public string BAchievement { get; set; }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            string jsonFromFile;
            using (var reader = new StreamReader(_fileName))
            {
                jsonFromFile = reader.ReadToEnd();
            }
            var resumeFromJson = JsonConvert.DeserializeObject<Resume>(jsonFromFile);

            string FirstName = resumeFromJson.FirstName;
            string MiddleName = resumeFromJson.MiddleName;
            string Surname = resumeFromJson.Surname;
            string FullName = resumeFromJson.FullName;
            string Email = resumeFromJson.Email;
            string AAddress = resumeFromJson.AAddress;
            string BAddress = resumeFromJson.BAddress;
            string ContactNumber = resumeFromJson.ContactNumber;
            string Askill = resumeFromJson.Askill;
            string Bskill = resumeFromJson.Bskill;
            string Cskill = resumeFromJson.Cskill;
            string Dskill = resumeFromJson.Dskill;
            string Eskill = resumeFromJson.Eskill;
            string Fskill = resumeFromJson.Fskill;
            string Gskill = resumeFromJson.Gskill;
            string Experience = resumeFromJson.Experience;
            string College = resumeFromJson.College;
            string SeniorHighSchool = resumeFromJson.SeniorHighSchool;
            string JuniorHighSchool = resumeFromJson.JuniorHighSchool;
            string Elementary = resumeFromJson.Elementary;
            string AAchievement = resumeFromJson.AAchievement;
            string BAchievement = resumeFromJson.BAchievement;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = @"C:\Users\Migo\OneDrive\Documents\RESUME";
                saveFileDialog.FileName = Surname + " " + FirstName + ".pdf";
                saveFileDialog.Filter = "PDF|*.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = Surname + "_" + "Resume";
                    PdfPage page = pdf.AddPage();

                    XGraphics graph = XGraphics.FromPdfPage(page);
                    XFont bigfont = new XFont("Garet", 18, XFontStyle.Bold);
                    XFont smallfont = new XFont("Garet", 14, XFontStyle.Regular);
                    XFont titlefont = new XFont("Garet", 35, XFontStyle.Bold);

                    XPen pen = new XPen(XColors.White, 20);
                    XPen linerleft = new XPen(XColors.LightBlue, 1); ;
                    XPen linerright = new XPen(XColors.LightBlue, 1);

                    graph.DrawRoundedRectangle(XBrushes.DarkBlue, 0, 0, page.Width.Point, page.Height.Point, 30, 20);
                    graph.DrawRoundedRectangle(XBrushes.White, 200, 50, page.Width.Point, page.Height.Point, 100, 100);
                    graph.DrawRectangle(pen, 0, 0, page.Width.Point, page.Height.Point);

                    graph.DrawString("ENTRY-LEVEL SOFTWARE ENGINEER:",bigfont, XBrushes.LightBlue, new XRect(0, 20, page.Width.Point - 20, page.Height.Point - 50), XStringFormats.TopRight);

                    int marginleft = 25;
                    int initialleft = 200;

                    string jpg = @"C:\Users\Migo\OneDrive\Documents\migo 2by2 for oop resume\Neri, Miguel Alfonso pic.jpg";
                    XImage image = XImage.FromFile(jpg);
                    graph.DrawImage(image, marginleft, 50, 150, 150);

                    graph.DrawString("PERSONAL INFO:", bigfont, XBrushes.LightBlue, new XRect(marginleft, initialleft + 10, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Email, smallfont, XBrushes.White, new XRect(marginleft, initialleft + 40, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(ContactNumber, smallfont, XBrushes.White, new XRect(marginleft, initialleft + 60, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(AAddress, smallfont, XBrushes.White, new XRect(marginleft, initialleft + 80, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(BAddress, smallfont, XBrushes.White, new XRect(marginleft, initialleft + 100, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawRectangle(linerleft, marginleft, initialleft + 30, 150, 1);

                    int marginmiddle = 220;
                    int initialmiddle = 180;

                    graph.DrawString(FirstName, titlefont, XBrushes.Black, new XRect(marginmiddle, initialmiddle - 110, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Surname, titlefont, XBrushes.Black, new XRect(marginmiddle, initialmiddle - 70, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawRectangle(linerright, marginmiddle, initialmiddle - 10, 350, 1);

                    graph.DrawString("SOFT AND HARD SKILLS:", bigfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Askill, smallfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle + 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Bskill, smallfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle + 50, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Cskill, smallfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle + 70, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Eskill, smallfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle + 90, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                  
                    initialmiddle = initialmiddle + 130;
                    graph.DrawRectangle(linerright, marginmiddle, initialmiddle - 5, 350, 1);

                    graph.DrawString("KEY ACHIEVEMENTS:", bigfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(AAchievement, smallfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle + 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(BAchievement, smallfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle + 50, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    initialmiddle = initialmiddle + 100;

                    graph.DrawRectangle(linerright, marginmiddle, initialmiddle - 5, 350, 1);


                    graph.DrawString("EDUCATION", bigfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(College, smallfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle + 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SeniorHighSchool, smallfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle + 50, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(JuniorHighSchool, smallfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle + 70, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Elementary, smallfont, XBrushes.Black, new XRect(marginmiddle, initialmiddle + 90, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    pdf.Save(saveFileDialog.FileName);
                }
                MessageBox.Show("SUCCESSFULLY GENERATED!");

            }
            Application.Restart();

        }
    }
}
