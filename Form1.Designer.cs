namespace WindowsForm_move
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureObstacle1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureFlag = new System.Windows.Forms.PictureBox();
            this.pictureTrap1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureObstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrap1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureObstacle1
            // 
            this.pictureObstacle1.Image = global::WindowsForm_move.Properties.Resources.brick;
            this.pictureObstacle1.Location = new System.Drawing.Point(155, -4);
            this.pictureObstacle1.Name = "pictureObstacle1";
            this.pictureObstacle1.Size = new System.Drawing.Size(100, 350);
            this.pictureObstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureObstacle1.TabIndex = 2;
            this.pictureObstacle1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsForm_move.Properties.Resources.charactor;
            this.pictureBox1.Location = new System.Drawing.Point(52, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureFlag
            // 
            this.pictureFlag.BackColor = System.Drawing.Color.Transparent;
            this.pictureFlag.Image = global::WindowsForm_move.Properties.Resources.flag;
            this.pictureFlag.Location = new System.Drawing.Point(760, 370);
            this.pictureFlag.Name = "pictureFlag";
            this.pictureFlag.Size = new System.Drawing.Size(50, 50);
            this.pictureFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFlag.TabIndex = 1;
            this.pictureFlag.TabStop = false;
            // 
            // pictureTrap1
            // 
            this.pictureTrap1.BackColor = System.Drawing.Color.Transparent;
            this.pictureTrap1.Image = global::WindowsForm_move.Properties.Resources.lurk_trap_;
            this.pictureTrap1.Location = new System.Drawing.Point(683, 241);
            this.pictureTrap1.Name = "pictureTrap1";
            this.pictureTrap1.Size = new System.Drawing.Size(80, 50);
            this.pictureTrap1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTrap1.TabIndex = 3;
            this.pictureTrap1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForm_move.Properties.Resources.grass;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.pictureTrap1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureFlag);
            this.Controls.Add(this.pictureObstacle1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureObstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrap1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureFlag;
        private System.Windows.Forms.PictureBox pictureObstacle1;
        private System.Windows.Forms.PictureBox pictureTrap1;
    }
}

