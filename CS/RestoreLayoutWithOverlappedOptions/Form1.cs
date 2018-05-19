using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using System.Collections;
using System.IO;

namespace RestoreLayoutWithOverlappedOptions {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnRestore_Click(object sender, EventArgs e) {
            
            string modifiedLayout = cleanupReportLayout(File.ReadAllText("TestLayout.repx"));
            File.WriteAllText("ModifiedLayout.repx", modifiedLayout);
            XtraReport report = XtraReport.FromFile("ModifiedLayout.repx", true);
            report.ShowPreview();
        }
        private string cleanupReportLayout(string ReportLayout) {
            if (!string.IsNullOrEmpty(ReportLayout)) {

                // Cleanup Report Layout if Required

                if (ReportLayout.Contains("OverlappingOptions")) {
                    ArrayList controlNames = new ArrayList();
                    using (StringWriter sw = new StringWriter()) {
                        using (StringReader sr = new StringReader(ReportLayout)) {

                            string line;
                            while ((line = sr.ReadLine()) != null) {
                                if (!line.Contains("OverlappingOptions")) {
                                    bool bFound = false;
                                    foreach (string controlName in controlNames) {
                                        if (line.Contains(controlName)) {
                                            bFound = true;
                                            break;
                                        }
                                    } 
                                    if (!bFound) {
                                        if (!line.Contains("OverlappingOptionsTypeName")) {
                                            sw.WriteLine(line);
                                        } 
                                    } 
                                }
                                else {
                                    char[] splitchar = new char[1];
                                    splitchar[0] = ' ';
                                    string[] parms = line.Trim().Split(splitchar);
                                    controlNames.Add(parms[0]);
                                } 
                            } 
                        }
                        ReportLayout = sw.ToString();
                    } 
                } 
            } 
            return ReportLayout;
        }
    }
}