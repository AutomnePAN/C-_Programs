namespace WeatherClient
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCelsius = new System.Windows.Forms.RadioButton();
            this.radioButtonFahrenheit = new System.Windows.Forms.RadioButton();
            this.labelCity = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textWeatherCondition = new System.Windows.Forms.TextBox();
            this.textTemperature = new System.Windows.Forms.TextBox();
            this.buttonGetWeather = new System.Windows.Forms.Button();
            this.labelWeatherCondition = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.radioButtonFahrenheit);
            this.groupBox1.Controls.Add(this.radioButtonCelsius);
            this.groupBox1.Location = new System.Drawing.Point(105, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature Mode";
            // 
            // radioButtonCelsius
            // 
            this.radioButtonCelsius.AutoSize = true;
            this.radioButtonCelsius.Checked = true;
            this.radioButtonCelsius.Location = new System.Drawing.Point(6, 35);
            this.radioButtonCelsius.Name = "radioButtonCelsius";
            this.radioButtonCelsius.Size = new System.Drawing.Size(84, 19);
            this.radioButtonCelsius.TabIndex = 0;
            this.radioButtonCelsius.TabStop = true;
            this.radioButtonCelsius.Text = "Celsius";
            this.radioButtonCelsius.UseVisualStyleBackColor = true;
            // 
            // radioButtonFahrenheit
            // 
            this.radioButtonFahrenheit.AutoSize = true;
            this.radioButtonFahrenheit.Location = new System.Drawing.Point(6, 60);
            this.radioButtonFahrenheit.Name = "radioButtonFahrenheit";
            this.radioButtonFahrenheit.Size = new System.Drawing.Size(108, 19);
            this.radioButtonFahrenheit.TabIndex = 1;
            this.radioButtonFahrenheit.TabStop = true;
            this.radioButtonFahrenheit.Text = "Farhenheit";
            this.radioButtonFahrenheit.UseVisualStyleBackColor = true;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(470, 147);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(55, 15);
            this.labelCity.TabIndex = 1;
            this.labelCity.Text = "City: ";
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(473, 175);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(100, 25);
            this.textCity.TabIndex = 2;
            // 
            // textWeatherCondition
            // 
            this.textWeatherCondition.Location = new System.Drawing.Point(473, 265);
            this.textWeatherCondition.Name = "textWeatherCondition";
            this.textWeatherCondition.Size = new System.Drawing.Size(241, 25);
            this.textWeatherCondition.TabIndex = 3;
            // 
            // textTemperature
            // 
            this.textTemperature.Location = new System.Drawing.Point(473, 350);
            this.textTemperature.Name = "textTemperature";
            this.textTemperature.Size = new System.Drawing.Size(241, 25);
            this.textTemperature.TabIndex = 4;
            // 
            // buttonGetWeather
            // 
            this.buttonGetWeather.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGetWeather.Location = new System.Drawing.Point(86, 349);
            this.buttonGetWeather.Name = "buttonGetWeather";
            this.buttonGetWeather.Size = new System.Drawing.Size(229, 23);
            this.buttonGetWeather.TabIndex = 5;
            this.buttonGetWeather.Text = "Get Weather";
            this.buttonGetWeather.UseVisualStyleBackColor = true;
            this.buttonGetWeather.Click += new System.EventHandler(this.buttonGetWeather_Click);
            // 
            // labelWeatherCondition
            // 
            this.labelWeatherCondition.AutoSize = true;
            this.labelWeatherCondition.Location = new System.Drawing.Point(470, 238);
            this.labelWeatherCondition.Name = "labelWeatherCondition";
            this.labelWeatherCondition.Size = new System.Drawing.Size(143, 15);
            this.labelWeatherCondition.TabIndex = 6;
            this.labelWeatherCondition.Text = "Weather Condition";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(470, 323);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(95, 15);
            this.labelTemperature.TabIndex = 7;
            this.labelTemperature.Text = "Temperature";
            this.labelTemperature.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.labelWeatherCondition);
            this.Controls.Add(this.buttonGetWeather);
            this.Controls.Add(this.textTemperature);
            this.Controls.Add(this.textWeatherCondition);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFahrenheit;
        private System.Windows.Forms.RadioButton radioButtonCelsius;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textWeatherCondition;
        private System.Windows.Forms.TextBox textTemperature;
        private System.Windows.Forms.Button buttonGetWeather;
        private System.Windows.Forms.Label labelWeatherCondition;
        private System.Windows.Forms.Label labelTemperature;
    }
}

