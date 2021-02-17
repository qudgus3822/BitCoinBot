namespace BitCoinBot
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_currentPrice = new System.Windows.Forms.Label();
            this.lb_fluctate = new System.Windows.Forms.Label();
            this.lb_fluctateRate = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_orderable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_sellable = new System.Windows.Forms.Label();
            this.tb_order = new System.Windows.Forms.TextBox();
            this.btn_buy = new System.Windows.Forms.Button();
            this.btn_sell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "현재시간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "현재가격";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "변동가격";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "변동률";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(122, 45);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(38, 12);
            this.lb_date.TabIndex = 5;
            this.lb_date.Text = "label5";
            // 
            // lb_currentPrice
            // 
            this.lb_currentPrice.AutoSize = true;
            this.lb_currentPrice.Location = new System.Drawing.Point(124, 82);
            this.lb_currentPrice.Name = "lb_currentPrice";
            this.lb_currentPrice.Size = new System.Drawing.Size(38, 12);
            this.lb_currentPrice.TabIndex = 6;
            this.lb_currentPrice.Text = "label6";
            // 
            // lb_fluctate
            // 
            this.lb_fluctate.AutoSize = true;
            this.lb_fluctate.Location = new System.Drawing.Point(124, 120);
            this.lb_fluctate.Name = "lb_fluctate";
            this.lb_fluctate.Size = new System.Drawing.Size(38, 12);
            this.lb_fluctate.TabIndex = 7;
            this.lb_fluctate.Text = "label7";
            // 
            // lb_fluctateRate
            // 
            this.lb_fluctateRate.AutoSize = true;
            this.lb_fluctateRate.Location = new System.Drawing.Point(124, 156);
            this.lb_fluctateRate.Name = "lb_fluctateRate";
            this.lb_fluctateRate.Size = new System.Drawing.Size(38, 12);
            this.lb_fluctateRate.TabIndex = 8;
            this.lb_fluctateRate.Text = "label8";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(407, 44);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(65, 12);
            this.lb_total.TabIndex = 9;
            this.lb_total.Text = "ㅅㅅㅅㅅㅅ";
            // 
            // lb_orderable
            // 
            this.lb_orderable.AutoSize = true;
            this.lb_orderable.Location = new System.Drawing.Point(407, 82);
            this.lb_orderable.Name = "lb_orderable";
            this.lb_orderable.Size = new System.Drawing.Size(65, 12);
            this.lb_orderable.TabIndex = 10;
            this.lb_orderable.Text = "ㅅㅅㅅㅅㅅ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "총 금액";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "매수 가능 금액";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "매도 가능 금액";
            // 
            // lb_sellable
            // 
            this.lb_sellable.AutoSize = true;
            this.lb_sellable.Location = new System.Drawing.Point(407, 120);
            this.lb_sellable.Name = "lb_sellable";
            this.lb_sellable.Size = new System.Drawing.Size(65, 12);
            this.lb_sellable.TabIndex = 15;
            this.lb_sellable.Text = "ㅅㅅㅅㅅㅅ";
            // 
            // tb_order
            // 
            this.tb_order.Location = new System.Drawing.Point(305, 167);
            this.tb_order.Name = "tb_order";
            this.tb_order.Size = new System.Drawing.Size(100, 21);
            this.tb_order.TabIndex = 16;
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(305, 194);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(75, 23);
            this.btn_buy.TabIndex = 17;
            this.btn_buy.Text = "매수";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // btn_sell
            // 
            this.btn_sell.Location = new System.Drawing.Point(386, 194);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(75, 23);
            this.btn_sell.TabIndex = 18;
            this.btn_sell.Text = "매도";
            this.btn_sell.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 243);
            this.Controls.Add(this.btn_sell);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.tb_order);
            this.Controls.Add(this.lb_sellable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_orderable);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.lb_fluctateRate);
            this.Controls.Add(this.lb_fluctate);
            this.Controls.Add(this.lb_currentPrice);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label lb_currentPrice;
        private System.Windows.Forms.Label lb_fluctate;
        private System.Windows.Forms.Label lb_fluctateRate;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label lb_orderable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_sellable;
        private System.Windows.Forms.TextBox tb_order;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Button btn_sell;
    }
}

