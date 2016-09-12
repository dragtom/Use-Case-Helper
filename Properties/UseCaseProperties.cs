using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Case_helper
{
    public partial class UseCaseProperties : Form
    {
        frmMain master;

        public UseCaseProperties(List<string> inputList, frmMain master)
        {
            InitializeComponent();
            /*
            inputlist:
            returnList.Add(name);
            returnList.Add(summary);
            returnList.Add(actors);
            returnList.Add(assumptions);
            returnList.Add(description);
            returnList.Add(exceptions);
            returnList.Add(result);
             */
            tbName.Text = inputList[0];
            tbSummary.Text = inputList[1];
            tbActors.Text = inputList[2];
            tbAssumptions.Text = inputList[3];
            tbDescription.Text = inputList[4];
            tbExceptions.Text = inputList[5];
            tbResult.Text = inputList[6];
            this.master = master;
        }

        private List<string> getOutputString()
        {
            List<string> outputList = new List<string>();
            outputList.Add(tbName.Text);
            outputList.Add(tbSummary.Text);
            outputList.Add(tbActors.Text);
            outputList.Add(tbAssumptions.Text);
            outputList.Add(tbDescription.Text);
            outputList.Add(tbExceptions.Text);
            outputList.Add(tbResult.Text);
            return outputList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            master.updateSelectedUseCase(getOutputString());
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
