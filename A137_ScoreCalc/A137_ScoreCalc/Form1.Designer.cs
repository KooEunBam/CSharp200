﻿namespace A137_ScoreCalc
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtKor = new System.Windows.Forms.TextBox();
      this.txtMath = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtEng = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtSum = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.btnCalc = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.txtAvg = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(20, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "국어";
      // 
      // txtKor
      // 
      this.txtKor.Location = new System.Drawing.Point(94, 36);
      this.txtKor.Name = "txtKor";
      this.txtKor.Size = new System.Drawing.Size(100, 27);
      this.txtKor.TabIndex = 1;
      this.txtKor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // txtMath
      // 
      this.txtMath.Location = new System.Drawing.Point(94, 78);
      this.txtMath.Name = "txtMath";
      this.txtMath.Size = new System.Drawing.Size(100, 27);
      this.txtMath.TabIndex = 3;
      this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(20, 83);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 20);
      this.label2.TabIndex = 2;
      this.label2.Text = "수학";
      // 
      // txtEng
      // 
      this.txtEng.Location = new System.Drawing.Point(94, 123);
      this.txtEng.Name = "txtEng";
      this.txtEng.Size = new System.Drawing.Size(100, 27);
      this.txtEng.TabIndex = 5;
      this.txtEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(20, 128);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(39, 20);
      this.label3.TabIndex = 4;
      this.label3.Text = "영어";
      // 
      // txtSum
      // 
      this.txtSum.Location = new System.Drawing.Point(94, 31);
      this.txtSum.Name = "txtSum";
      this.txtSum.ReadOnly = true;
      this.txtSum.Size = new System.Drawing.Size(100, 27);
      this.txtSum.TabIndex = 7;
      this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(20, 36);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(39, 20);
      this.label4.TabIndex = 6;
      this.label4.Text = "총점";
      // 
      // btnCalc
      // 
      this.btnCalc.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnCalc.Location = new System.Drawing.Point(379, 158);
      this.btnCalc.Name = "btnCalc";
      this.btnCalc.Size = new System.Drawing.Size(100, 33);
      this.btnCalc.TabIndex = 8;
      this.btnCalc.Text = "계산";
      this.btnCalc.UseVisualStyleBackColor = true;
      this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtKor);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.txtMath);
      this.groupBox1.Controls.Add(this.txtEng);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.groupBox1.Location = new System.Drawing.Point(33, 30);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(215, 168);
      this.groupBox1.TabIndex = 9;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "성적입력";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtAvg);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.txtSum);
      this.groupBox2.Controls.Add(this.label4);
      this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.groupBox2.Location = new System.Drawing.Point(285, 30);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(214, 118);
      this.groupBox2.TabIndex = 10;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "결과";
      // 
      // txtAvg
      // 
      this.txtAvg.Location = new System.Drawing.Point(94, 73);
      this.txtAvg.Name = "txtAvg";
      this.txtAvg.ReadOnly = true;
      this.txtAvg.Size = new System.Drawing.Size(100, 27);
      this.txtAvg.TabIndex = 9;
      this.txtAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(20, 78);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(39, 20);
      this.label5.TabIndex = 8;
      this.label5.Text = "평균";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(524, 224);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnCalc);
      this.Name = "Form1";
      this.Text = "성적계산기";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtKor;
    private System.Windows.Forms.TextBox txtMath;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtEng;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtSum;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnCalc;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox txtAvg;
    private System.Windows.Forms.Label label5;
  }
}

