using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessControlSystem
{
    public partial class FormJournal : Form
    {
        public FormJournal()
        {
            InitializeComponent();
        }

        private void FormJournal_Load(object sender, EventArgs e)
        {
            this.view_journal_key_userTableAdapter.Fill(this.accessControlSystemDataSet.View_journal_key_user);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string filtrString = "";
            long _checked = 0;
            foreach (Control cb in panelfind.Controls)
            {
                if (cb is CheckBox)
                {
                    if (((CheckBox)cb).Checked)
                    {
                        if (_checked != 0)
                            filtrString += @" AND";

                        switch (cb.Name)
                        {
                            case "checkBoxSname":
                                filtrString += string.Format(" Second_name LIKE '%{0}%'", textBoxSname.Text);
                                break;
                            case "checkBoxName":
                                filtrString += string.Format(" Name LIKE '%{0}%'", textBoxName.Text);
                                break;
                            case "checkBoxPat":
                                filtrString += string.Format(" Patronymic LIKE '%{0}%'", textBoxPat.Text);
                                break;
                            case "checkBoxStatus":
                                filtrString += string.Format(" Role LIKE '%{0}%'", textBoxStatus.Text);
                                break;
                            case "checkBoxRoom":
                                filtrString += string.Format(" Room_name LIKE '%{0}%'", textBoxRoom.Text);
                                break;
                            case "checkBoxAction":
                                filtrString += string.Format(" Action LIKE '%{0}%'", textBoxAction.Text);
                                break;
                            case "checkBoxDate":
                                //filtrString += string.Format(" Education = ##", textBoxEdu.Text);
                                break;
                        }
                        _checked++;
                    }
                }
            }
            this.view_journal_key_userBindingSource.Filter = filtrString;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.view_journal_key_userBindingSource.RemoveFilter();
        }
        
    }
}
