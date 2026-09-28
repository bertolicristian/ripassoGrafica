namespace ripassoGrafica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            notifyIcon1 = new NotifyIcon(components);
            utente = new TextBox();
            nome = new Label();
            pass = new TextBox();
            password = new Label();
            gmail = new TextBox();
            mail = new Label();
            errore = new Label();
            accesso = new Label();
            accedi = new Button();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // utente
            // 
            utente.Location = new Point(26, 49);
            utente.Name = "utente";
            utente.Size = new Size(100, 23);
            utente.TabIndex = 0;
            utente.TextChanged += utente_TextChanged;
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Location = new Point(26, 31);
            nome.Name = "nome";
            nome.Size = new Size(75, 15);
            nome.TabIndex = 1;
            nome.Text = "nome utente";
            // 
            // pass
            // 
            pass.Location = new Point(26, 111);
            pass.Name = "pass";
            pass.Size = new Size(100, 23);
            pass.TabIndex = 2;
            pass.TextChanged += pass_TextChanged;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(26, 93);
            password.Name = "password";
            password.Size = new Size(57, 15);
            password.TabIndex = 3;
            password.Text = "password";
            // 
            // gmail
            // 
            gmail.Location = new Point(26, 173);
            gmail.Name = "gmail";
            gmail.Size = new Size(100, 23);
            gmail.TabIndex = 4;
            gmail.TextChanged += gmail_TextChanged;
            // 
            // mail
            // 
            mail.AutoSize = true;
            mail.Location = new Point(26, 155);
            mail.Name = "mail";
            mail.Size = new Size(36, 15);
            mail.TabIndex = 5;
            mail.Text = "email";
            // 
            // errore
            // 
            errore.AutoSize = true;
            errore.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errore.ForeColor = Color.Red;
            errore.Location = new Point(26, 262);
            errore.Name = "errore";
            errore.Size = new Size(79, 25);
            errore.TabIndex = 6;
            errore.Text = "ERRORE";
            // 
            // accesso
            // 
            accesso.AutoSize = true;
            accesso.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accesso.ForeColor = Color.Lime;
            accesso.Location = new Point(26, 262);
            accesso.Name = "accesso";
            accesso.Size = new Size(175, 25);
            accesso.TabIndex = 7;
            accesso.Text = "ACCESSO RIUSCITO";
            // 
            // accedi
            // 
            accedi.Location = new Point(26, 225);
            accedi.Name = "accedi";
            accedi.Size = new Size(75, 23);
            accedi.TabIndex = 8;
            accedi.Text = "accedi";
            accedi.UseVisualStyleBackColor = true;
            accedi.Click += accedi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(accedi);
            Controls.Add(accesso);
            Controls.Add(errore);
            Controls.Add(mail);
            Controls.Add(gmail);
            Controls.Add(password);
            Controls.Add(pass);
            Controls.Add(nome);
            Controls.Add(utente);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NotifyIcon notifyIcon1;
        private TextBox utente;
        private Label nome;
        private TextBox pass;
        private Label password;
        private TextBox gmail;
        private Label mail;
        private Label errore;
        private Label accesso;
        private Button accedi;
    }
}
