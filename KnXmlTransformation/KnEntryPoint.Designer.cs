namespace KnXmlTransformation
{
    partial class KnEntryPoint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtXmlOutput = new System.Windows.Forms.TextBox();
            this.btnAnother = new System.Windows.Forms.Button();
            this.btnLoopXml = new System.Windows.Forms.Button();
            this.btnTransform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtXmlOutput
            // 
            this.txtXmlOutput.Location = new System.Drawing.Point(3, 54);
            this.txtXmlOutput.Multiline = true;
            this.txtXmlOutput.Name = "txtXmlOutput";
            this.txtXmlOutput.Size = new System.Drawing.Size(658, 299);
            this.txtXmlOutput.TabIndex = 2;
            // 
            // btnAnother
            // 
            this.btnAnother.Location = new System.Drawing.Point(397, 25);
            this.btnAnother.Name = "btnAnother";
            this.btnAnother.Size = new System.Drawing.Size(65, 23);
            this.btnAnother.TabIndex = 6;
            this.btnAnother.Text = "Another";
            this.btnAnother.UseVisualStyleBackColor = true;
            this.btnAnother.Click += new System.EventHandler(this.btnAnother_Click);
            // 
            // btnLoopXml
            // 
            this.btnLoopXml.Location = new System.Drawing.Point(468, 25);
            this.btnLoopXml.Name = "btnLoopXml";
            this.btnLoopXml.Size = new System.Drawing.Size(75, 23);
            this.btnLoopXml.TabIndex = 5;
            this.btnLoopXml.Text = "Xml Loop";
            this.btnLoopXml.UseVisualStyleBackColor = true;
            this.btnLoopXml.Click += new System.EventHandler(this.btnLoopXml_Click);
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(549, 25);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(102, 23);
            this.btnTransform.TabIndex = 4;
            this.btnTransform.Text = "Transform";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // KnEntryPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 355);
            this.Controls.Add(this.btnAnother);
            this.Controls.Add(this.btnLoopXml);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.txtXmlOutput);
            this.Name = "KnEntryPoint";
            this.Text = "Kn XML - XSL Transformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtXmlOutput;
        private System.Windows.Forms.Button btnAnother;
        private System.Windows.Forms.Button btnLoopXml;
        private System.Windows.Forms.Button btnTransform;
    }
}

