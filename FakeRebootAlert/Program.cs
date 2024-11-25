using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


class Program
{
    static void Main()
    {
        string hostName = Environment.MachineName;
        string message = $"Falcon agent failed to update. Please restart your device.";
        string cabecera = $"Agent Update Failure ({hostName})";
        string base64Icon = "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";
        ShowCustomMessageBox(message, cabecera, base64Icon);
    }


    static void ShowCustomMessageBox(string message, string title, string base64Icon)
    {
        Form form = new Form();
        form.Text = title;
        form.Size = new Size(381, 133);
        form.StartPosition = FormStartPosition.CenterScreen;
        form.FormBorderStyle = FormBorderStyle.FixedDialog;
        form.MaximizeBox = false;
        form.MinimizeBox = false;

        using (MemoryStream iconStream = new MemoryStream(Convert.FromBase64String(base64Icon)))
        {
            form.Icon = new Icon(iconStream);
        }

        Panel buttonPanel = new Panel();
        buttonPanel.Dock = DockStyle.Bottom;
        buttonPanel.Height = 40;

        Button closeButton = new Button();
        closeButton.Text = "Close";
        closeButton.DialogResult = DialogResult.OK;
        closeButton.Size = new Size(80, 30);
        closeButton.Anchor = AnchorStyles.None;
        closeButton.Location = new Point((form.ClientSize.Width - closeButton.Width) / 2 - 70, 3);
        buttonPanel.Controls.Add(closeButton);

        Label messageLabel = new Label();
        messageLabel.Text = message;
        messageLabel.Font = new Font("Arial", 9, FontStyle.Bold);
        messageLabel.AutoSize = false;
        messageLabel.TextAlign = ContentAlignment.MiddleCenter;
        messageLabel.Dock = DockStyle.Fill;
        messageLabel.Padding = new Padding(8);

        form.Controls.Add(messageLabel);
        form.Controls.Add(buttonPanel);
        form.AcceptButton = closeButton;

        form.ShowDialog();
    }
}