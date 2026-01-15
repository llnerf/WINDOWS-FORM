using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Langit_Multiplexing_Multicasting
{
    public partial class Form1 : Form
    {
        // Delegate that represents actions when an announcement is sent
        delegate void AnnouncementHandler(string message);

        // Event for multicasting (multiple methods called at once)
        event AnnouncementHandler SendAnnouncement;

        public Form1()
         {
            InitializeComponent();

            // Add recipients to ComboBox
            cmbRecipient.Items.Add("All Students");
            cmbRecipient.Items.Add("Teachers");
            cmbRecipient.Items.Add("Administration");
            cmbRecipient.SelectedIndex = 0;

            // Attach multiple methods to one event (multicasting)
            SendAnnouncement += DisplayAnnouncement;
            SendAnnouncement += UpdateStatus;
            SendAnnouncement += LogAnnouncement;
         }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            string recipient = cmbRecipient.SelectedItem.ToString();

            // Multiplexing: one button, different behavior
            if (recipient == "All Students")
            {
                SendAnnouncement?.Invoke("To Students: " + message);
            }
            else if (recipient == "Teachers")
            {
                SendAnnouncement?.Invoke("To Teachers: " + message);
            }
            else if (recipient == "Administration")
            {
                SendAnnouncement?.Invoke("To Administration: " + message);
            }
        }
        // Displays the announcement on the form
        private void DisplayAnnouncement(string message)
        {
            lblDisplaye.Text = "Announcement: " + message;
        }

        // Updates the status label with time sent
        private void UpdateStatus(string message)
        {
            lblStatus.Text = "Status: Message sent at " +
                             DateTime.Now.ToLongTimeString();
        }

        // Adds the announcement to the log list
        private void LogAnnouncement(string message)
        {
            lstLog.Items.Add(DateTime.Now.ToShortTimeString() +
                             " - " + message);
        }

        
    }
}
