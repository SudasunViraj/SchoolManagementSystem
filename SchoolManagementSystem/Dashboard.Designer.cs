
namespace SchoolManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newAdmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentAdmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherAdmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectAdmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examAdmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSchoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentAgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAdmissionToolStripMenuItem,
            this.searchStudentToolStripMenuItem,
            this.deleteStudentToolStripMenuItem,
            this.feedbackToolStripMenuItem,
            this.aboutSchoolToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(816, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newAdmissionToolStripMenuItem
            // 
            this.newAdmissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentAdmissionToolStripMenuItem,
            this.teacherAdmissionToolStripMenuItem,
            this.subjectAdmissionToolStripMenuItem,
            this.examAdmissionToolStripMenuItem});
            this.newAdmissionToolStripMenuItem.Name = "newAdmissionToolStripMenuItem";
            this.newAdmissionToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.newAdmissionToolStripMenuItem.Text = "Admission";
            // 
            // studentAdmissionToolStripMenuItem
            // 
            this.studentAdmissionToolStripMenuItem.Name = "studentAdmissionToolStripMenuItem";
            this.studentAdmissionToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.studentAdmissionToolStripMenuItem.Text = "Student Admission";
            this.studentAdmissionToolStripMenuItem.Click += new System.EventHandler(this.studentAdmissionToolStripMenuItem_Click);
            // 
            // teacherAdmissionToolStripMenuItem
            // 
            this.teacherAdmissionToolStripMenuItem.Name = "teacherAdmissionToolStripMenuItem";
            this.teacherAdmissionToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.teacherAdmissionToolStripMenuItem.Text = "Teacher Admission";
            this.teacherAdmissionToolStripMenuItem.Click += new System.EventHandler(this.teacherAdmissionToolStripMenuItem_Click);
            // 
            // subjectAdmissionToolStripMenuItem
            // 
            this.subjectAdmissionToolStripMenuItem.Name = "subjectAdmissionToolStripMenuItem";
            this.subjectAdmissionToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.subjectAdmissionToolStripMenuItem.Text = "Subject Admission";
            this.subjectAdmissionToolStripMenuItem.Click += new System.EventHandler(this.subjectAdmissionToolStripMenuItem_Click);
            // 
            // examAdmissionToolStripMenuItem
            // 
            this.examAdmissionToolStripMenuItem.Name = "examAdmissionToolStripMenuItem";
            this.examAdmissionToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.examAdmissionToolStripMenuItem.Text = "Exam Admission";
            this.examAdmissionToolStripMenuItem.Click += new System.EventHandler(this.examAdmissionToolStripMenuItem_Click);
            // 
            // searchStudentToolStripMenuItem
            // 
            this.searchStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchStudentToolStripMenuItem1,
            this.searchTeacherToolStripMenuItem,
            this.searchModuleToolStripMenuItem,
            this.searchExamToolStripMenuItem});
            this.searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.searchStudentToolStripMenuItem.Text = "Find Details";
            // 
            // searchStudentToolStripMenuItem1
            // 
            this.searchStudentToolStripMenuItem1.Name = "searchStudentToolStripMenuItem1";
            this.searchStudentToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.searchStudentToolStripMenuItem1.Text = "Search Student";
            this.searchStudentToolStripMenuItem1.Click += new System.EventHandler(this.searchStudentToolStripMenuItem1_Click);
            // 
            // searchTeacherToolStripMenuItem
            // 
            this.searchTeacherToolStripMenuItem.Name = "searchTeacherToolStripMenuItem";
            this.searchTeacherToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.searchTeacherToolStripMenuItem.Text = "Search Teacher";
            this.searchTeacherToolStripMenuItem.Click += new System.EventHandler(this.searchTeacherToolStripMenuItem_Click);
            // 
            // searchModuleToolStripMenuItem
            // 
            this.searchModuleToolStripMenuItem.Name = "searchModuleToolStripMenuItem";
            this.searchModuleToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.searchModuleToolStripMenuItem.Text = "Search Module";
            this.searchModuleToolStripMenuItem.Click += new System.EventHandler(this.searchModuleToolStripMenuItem_Click);
            // 
            // searchExamToolStripMenuItem
            // 
            this.searchExamToolStripMenuItem.Name = "searchExamToolStripMenuItem";
            this.searchExamToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.searchExamToolStripMenuItem.Text = "Search Exam";
            this.searchExamToolStripMenuItem.Click += new System.EventHandler(this.searchExamToolStripMenuItem_Click);
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateStudentToolStripMenuItem,
            this.updateTeacherToolStripMenuItem,
            this.updateModuleToolStripMenuItem});
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.deleteStudentToolStripMenuItem.Text = "Update Details";
            this.deleteStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentToolStripMenuItem_Click);
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentAgeToolStripMenuItem});
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.feedbackToolStripMenuItem.Text = "Additional Functions";
            // 
            // aboutSchoolToolStripMenuItem
            // 
            this.aboutSchoolToolStripMenuItem.Name = "aboutSchoolToolStripMenuItem";
            this.aboutSchoolToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.aboutSchoolToolStripMenuItem.Text = "Exit System";
            this.aboutSchoolToolStripMenuItem.Click += new System.EventHandler(this.aboutSchoolToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(323, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome";
            // 
            // updateStudentToolStripMenuItem
            // 
            this.updateStudentToolStripMenuItem.Name = "updateStudentToolStripMenuItem";
            this.updateStudentToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.updateStudentToolStripMenuItem.Text = "Update Student";
            this.updateStudentToolStripMenuItem.Click += new System.EventHandler(this.updateStudentToolStripMenuItem_Click);
            // 
            // updateTeacherToolStripMenuItem
            // 
            this.updateTeacherToolStripMenuItem.Name = "updateTeacherToolStripMenuItem";
            this.updateTeacherToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.updateTeacherToolStripMenuItem.Text = "Update Teacher";
            this.updateTeacherToolStripMenuItem.Click += new System.EventHandler(this.updateTeacherToolStripMenuItem_Click);
            // 
            // updateModuleToolStripMenuItem
            // 
            this.updateModuleToolStripMenuItem.Name = "updateModuleToolStripMenuItem";
            this.updateModuleToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.updateModuleToolStripMenuItem.Text = "Update Module";
            this.updateModuleToolStripMenuItem.Click += new System.EventHandler(this.updateModuleToolStripMenuItem_Click);
            // 
            // studentAgeToolStripMenuItem
            // 
            this.studentAgeToolStripMenuItem.Name = "studentAgeToolStripMenuItem";
            this.studentAgeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.studentAgeToolStripMenuItem.Text = "Student Age";
            this.studentAgeToolStripMenuItem.Click += new System.EventHandler(this.studentAgeToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newAdmissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSchoolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentAdmissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherAdmissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectAdmissionToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem examAdmissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchModuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem updateStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateModuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentAgeToolStripMenuItem;
    }
}