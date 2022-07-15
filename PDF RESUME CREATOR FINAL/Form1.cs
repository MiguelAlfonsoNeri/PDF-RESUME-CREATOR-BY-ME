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
            public string MiddleNme { get; set; }
            public string Surname { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
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
            string MiddleName = resumeFromJson.MiddleNme;
            string Surname = resumeFromJson.Surname;
            string Email = resumeFromJson.Email;
            string Address = resumeFromJson.Address;
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
            string AAchievement = resumeFromJson.AAchievement;
            string BAchievement = resumeFromJson.BAchievement;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = @"C:\Users\Public\Documents\Resume";
                saveFileDialog.FileName = Surname + " " + FirstName + ".pdf";
                saveFileDialog.Filter = "PDF|*.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = Surname + "_" + "Resume";
                    PdfPage page = pdf.AddPage();

                }

            }


        }
    }
}
