namespace Datan_ImageProcessing
{
    partial class ImageProcessing
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            loadBtn = new Button();
            saveBtn = new Button();
            copyBtn = new Button();
            greyBtn = new Button();
            invertBtn = new Button();
            histoBtn = new Button();
            sepiaBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            pictureBox3 = new PictureBox();
            backbtn = new Button();
            subtractBtn = new Button();
            openFileDialog2 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 292);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(327, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(309, 292);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // loadBtn
            // 
            loadBtn.BackColor = Color.Honeydew;
            loadBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loadBtn.Location = new Point(12, 310);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(108, 23);
            loadBtn.TabIndex = 2;
            loadBtn.Text = "Load Image";
            loadBtn.UseVisualStyleBackColor = false;
            loadBtn.Click += loadBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Honeydew;
            saveBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Location = new Point(327, 647);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(108, 23);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Save Image";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // copyBtn
            // 
            copyBtn.BackColor = Color.Honeydew;
            copyBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            copyBtn.Location = new Point(118, 382);
            copyBtn.Name = "copyBtn";
            copyBtn.Size = new Size(108, 23);
            copyBtn.TabIndex = 4;
            copyBtn.Text = "Copy Image";
            copyBtn.UseVisualStyleBackColor = false;
            copyBtn.Click += copyBtn_Click;
            // 
            // greyBtn
            // 
            greyBtn.BackColor = Color.Honeydew;
            greyBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            greyBtn.Location = new Point(118, 426);
            greyBtn.Name = "greyBtn";
            greyBtn.Size = new Size(108, 23);
            greyBtn.TabIndex = 5;
            greyBtn.Text = "Greyscale";
            greyBtn.UseVisualStyleBackColor = false;
            greyBtn.Click += greyBtn_Click;
            // 
            // invertBtn
            // 
            invertBtn.BackColor = Color.Honeydew;
            invertBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            invertBtn.Location = new Point(118, 472);
            invertBtn.Name = "invertBtn";
            invertBtn.Size = new Size(108, 23);
            invertBtn.TabIndex = 6;
            invertBtn.Text = "Invert Image";
            invertBtn.UseVisualStyleBackColor = false;
            invertBtn.Click += invertBtn_Click;
            // 
            // histoBtn
            // 
            histoBtn.BackColor = Color.Honeydew;
            histoBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            histoBtn.Location = new Point(118, 514);
            histoBtn.Name = "histoBtn";
            histoBtn.Size = new Size(108, 23);
            histoBtn.TabIndex = 7;
            histoBtn.Text = "Histogram";
            histoBtn.UseVisualStyleBackColor = false;
            histoBtn.Click += histoBtn_Click;
            // 
            // sepiaBtn
            // 
            sepiaBtn.BackColor = Color.Honeydew;
            sepiaBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sepiaBtn.Location = new Point(118, 553);
            sepiaBtn.Name = "sepiaBtn";
            sepiaBtn.Size = new Size(108, 23);
            sepiaBtn.TabIndex = 8;
            sepiaBtn.Text = "Sepia";
            sepiaBtn.UseVisualStyleBackColor = false;
            sepiaBtn.Click += sepiaBtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(327, 349);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(309, 292);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.Honeydew;
            backbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            backbtn.Location = new Point(327, 310);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(108, 23);
            backbtn.TabIndex = 10;
            backbtn.Text = "Load Background";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // subtractBtn
            // 
            subtractBtn.BackColor = Color.Honeydew;
            subtractBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            subtractBtn.Location = new Point(118, 594);
            subtractBtn.Name = "subtractBtn";
            subtractBtn.Size = new Size(108, 23);
            subtractBtn.TabIndex = 11;
            subtractBtn.Text = "Subtract";
            subtractBtn.UseVisualStyleBackColor = false;
            subtractBtn.Click += subtractBtn_Click;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // ImageProcessing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(647, 682);
            Controls.Add(subtractBtn);
            Controls.Add(backbtn);
            Controls.Add(pictureBox3);
            Controls.Add(sepiaBtn);
            Controls.Add(histoBtn);
            Controls.Add(invertBtn);
            Controls.Add(greyBtn);
            Controls.Add(copyBtn);
            Controls.Add(saveBtn);
            Controls.Add(loadBtn);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "ImageProcessing";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button loadBtn;
        private Button saveBtn;
        private Button copyBtn;
        private Button greyBtn;
        private Button invertBtn;
        private Button histoBtn;
        private Button sepiaBtn;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PictureBox pictureBox3;
        private Button backbtn;
        private Button subtractBtn;
        private OpenFileDialog openFileDialog2;
    }
}