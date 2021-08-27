
namespace Sploitgate
{
    partial class SploitGate
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SploitGate));
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.triggerbotGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.triggerLabel = new System.Windows.Forms.Label();
            this.triggerbotToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.configsaveButton = new Guna.UI2.WinForms.Guna2Button();
            this.miscGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rightclickLabel = new System.Windows.Forms.Label();
            this.rightclickToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.loadconfigsComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chromamodeLabel = new System.Windows.Forms.Label();
            this.chromamodeToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lightmodeLabel = new System.Windows.Forms.Label();
            this.lightmodeToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.triggerbotoptionsGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.quickscopeLabel = new System.Windows.Forms.Label();
            this.quickscopeToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.humanizationLabel = new System.Windows.Forms.Label();
            this.humanizeToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.antirecoilstrengthLabel = new System.Windows.Forms.Label();
            this.antirecoilstrengthTrackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.antirecoilToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.delayLabel = new System.Windows.Forms.Label();
            this.shotdelayTrackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.shottysnipersLabel = new System.Windows.Forms.Label();
            this.shottysnipersToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.ChromamodeTimer = new System.Windows.Forms.Timer(this.components);
            this.Transition = new Guna.UI2.WinForms.Guna2Transition();
            this.subLabel = new System.Windows.Forms.Label();
            this.humanizationTimer = new System.Windows.Forms.Timer(this.components);
            this.motdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            this.triggerbotGroupBox.SuspendLayout();
            this.miscGroupBox.SuspendLayout();
            this.triggerbotoptionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = this;
            this.StyleManager.Style = MetroFramework.MetroColorStyle.Purple;
            this.StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.Transition.SetDecoration(this.welcomeLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(4, 372);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(169, 21);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome to Sploitgate.";
            this.welcomeLabel.Visible = false;
            // 
            // triggerbotGroupBox
            // 
            this.triggerbotGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.triggerbotGroupBox.BorderRadius = 8;
            this.triggerbotGroupBox.BorderThickness = 0;
            this.triggerbotGroupBox.Controls.Add(this.triggerLabel);
            this.triggerbotGroupBox.Controls.Add(this.triggerbotToggleSwitch);
            this.triggerbotGroupBox.CustomBorderColor = System.Drawing.Color.BlueViolet;
            this.triggerbotGroupBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Transition.SetDecoration(this.triggerbotGroupBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.triggerbotGroupBox.FillColor = System.Drawing.Color.Indigo;
            this.triggerbotGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triggerbotGroupBox.ForeColor = System.Drawing.Color.White;
            this.triggerbotGroupBox.Location = new System.Drawing.Point(135, 68);
            this.triggerbotGroupBox.Name = "triggerbotGroupBox";
            this.triggerbotGroupBox.ShadowDecoration.Parent = this.triggerbotGroupBox;
            this.triggerbotGroupBox.Size = new System.Drawing.Size(192, 280);
            this.triggerbotGroupBox.TabIndex = 2;
            this.triggerbotGroupBox.Text = "Triggerbot";
            this.triggerbotGroupBox.TextOffset = new System.Drawing.Point(0, -5);
            this.triggerbotGroupBox.Visible = false;
            // 
            // triggerLabel
            // 
            this.triggerLabel.AutoSize = true;
            this.triggerLabel.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.triggerLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.triggerLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.triggerLabel.ForeColor = System.Drawing.Color.White;
            this.triggerLabel.Location = new System.Drawing.Point(3, 37);
            this.triggerLabel.Name = "triggerLabel";
            this.triggerLabel.Size = new System.Drawing.Size(79, 20);
            this.triggerLabel.TabIndex = 10;
            this.triggerLabel.Text = "Triggerbot";
            // 
            // triggerbotToggleSwitch
            // 
            this.triggerbotToggleSwitch.Animated = true;
            this.triggerbotToggleSwitch.BackColor = System.Drawing.Color.Transparent;
            this.triggerbotToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.triggerbotToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.triggerbotToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.triggerbotToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.triggerbotToggleSwitch.CheckedState.Parent = this.triggerbotToggleSwitch;
            this.Transition.SetDecoration(this.triggerbotToggleSwitch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.triggerbotToggleSwitch.Location = new System.Drawing.Point(150, 36);
            this.triggerbotToggleSwitch.Name = "triggerbotToggleSwitch";
            this.triggerbotToggleSwitch.ShadowDecoration.Parent = this.triggerbotToggleSwitch;
            this.triggerbotToggleSwitch.Size = new System.Drawing.Size(35, 20);
            this.triggerbotToggleSwitch.TabIndex = 9;
            this.triggerbotToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.triggerbotToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.triggerbotToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.triggerbotToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.triggerbotToggleSwitch.UncheckedState.Parent = this.triggerbotToggleSwitch;
            this.triggerbotToggleSwitch.CheckedChanged += new System.EventHandler(this.triggerbotToggleSwitch_CheckedChanged);
            // 
            // configsaveButton
            // 
            this.configsaveButton.Animated = true;
            this.configsaveButton.BorderRadius = 8;
            this.configsaveButton.CheckedState.Parent = this.configsaveButton;
            this.configsaveButton.CustomImages.Parent = this.configsaveButton;
            this.Transition.SetDecoration(this.configsaveButton, Guna.UI2.AnimatorNS.DecorationType.None);
            this.configsaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.configsaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.configsaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.configsaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.configsaveButton.DisabledState.Parent = this.configsaveButton;
            this.configsaveButton.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.configsaveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.configsaveButton.ForeColor = System.Drawing.Color.White;
            this.configsaveButton.HoverState.Parent = this.configsaveButton;
            this.configsaveButton.Location = new System.Drawing.Point(9, 179);
            this.configsaveButton.Name = "configsaveButton";
            this.configsaveButton.ShadowDecoration.Parent = this.configsaveButton;
            this.configsaveButton.Size = new System.Drawing.Size(175, 36);
            this.configsaveButton.TabIndex = 11;
            this.configsaveButton.Text = "Save Config";
            this.configsaveButton.Click += new System.EventHandler(this.configsaveButton_Click);
            // 
            // miscGroupBox
            // 
            this.miscGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.miscGroupBox.BorderRadius = 8;
            this.miscGroupBox.BorderThickness = 0;
            this.miscGroupBox.Controls.Add(this.rightclickLabel);
            this.miscGroupBox.Controls.Add(this.rightclickToggleSwitch);
            this.miscGroupBox.Controls.Add(this.loadconfigsComboBox);
            this.miscGroupBox.Controls.Add(this.configsaveButton);
            this.miscGroupBox.Controls.Add(this.chromamodeLabel);
            this.miscGroupBox.Controls.Add(this.chromamodeToggleSwitch);
            this.miscGroupBox.Controls.Add(this.lightmodeLabel);
            this.miscGroupBox.Controls.Add(this.lightmodeToggleSwitch);
            this.miscGroupBox.CustomBorderColor = System.Drawing.Color.BlueViolet;
            this.miscGroupBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Transition.SetDecoration(this.miscGroupBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.miscGroupBox.FillColor = System.Drawing.Color.Indigo;
            this.miscGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscGroupBox.ForeColor = System.Drawing.Color.White;
            this.miscGroupBox.Location = new System.Drawing.Point(541, 68);
            this.miscGroupBox.Name = "miscGroupBox";
            this.miscGroupBox.ShadowDecoration.Parent = this.miscGroupBox;
            this.miscGroupBox.Size = new System.Drawing.Size(192, 280);
            this.miscGroupBox.TabIndex = 3;
            this.miscGroupBox.Text = "Miscellaneous";
            this.miscGroupBox.TextOffset = new System.Drawing.Point(0, -5);
            this.miscGroupBox.Visible = false;
            // 
            // rightclickLabel
            // 
            this.rightclickLabel.AutoSize = true;
            this.rightclickLabel.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.rightclickLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.rightclickLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.rightclickLabel.ForeColor = System.Drawing.Color.White;
            this.rightclickLabel.Location = new System.Drawing.Point(7, 119);
            this.rightclickLabel.Name = "rightclickLabel";
            this.rightclickLabel.Size = new System.Drawing.Size(79, 20);
            this.rightclickLabel.TabIndex = 14;
            this.rightclickLabel.Text = "Right Click";
            // 
            // rightclickToggleSwitch
            // 
            this.rightclickToggleSwitch.Animated = true;
            this.rightclickToggleSwitch.BackColor = System.Drawing.Color.Transparent;
            this.rightclickToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rightclickToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rightclickToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.rightclickToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rightclickToggleSwitch.CheckedState.Parent = this.rightclickToggleSwitch;
            this.Transition.SetDecoration(this.rightclickToggleSwitch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.rightclickToggleSwitch.Location = new System.Drawing.Point(150, 119);
            this.rightclickToggleSwitch.Name = "rightclickToggleSwitch";
            this.rightclickToggleSwitch.ShadowDecoration.Parent = this.rightclickToggleSwitch;
            this.rightclickToggleSwitch.Size = new System.Drawing.Size(35, 20);
            this.rightclickToggleSwitch.TabIndex = 13;
            this.rightclickToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rightclickToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rightclickToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.rightclickToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.rightclickToggleSwitch.UncheckedState.Parent = this.rightclickToggleSwitch;
            this.rightclickToggleSwitch.CheckedChanged += new System.EventHandler(this.rightclickToggleSwitch_CheckedChanged);
            // 
            // loadconfigsComboBox
            // 
            this.loadconfigsComboBox.BackColor = System.Drawing.Color.Transparent;
            this.loadconfigsComboBox.BorderRadius = 8;
            this.loadconfigsComboBox.BorderThickness = 0;
            this.Transition.SetDecoration(this.loadconfigsComboBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.loadconfigsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.loadconfigsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loadconfigsComboBox.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.loadconfigsComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loadconfigsComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loadconfigsComboBox.FocusedState.Parent = this.loadconfigsComboBox;
            this.loadconfigsComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.loadconfigsComboBox.ForeColor = System.Drawing.Color.White;
            this.loadconfigsComboBox.HoverState.Parent = this.loadconfigsComboBox;
            this.loadconfigsComboBox.ItemHeight = 30;
            this.loadconfigsComboBox.Items.AddRange(new object[] {
            "Load Configs"});
            this.loadconfigsComboBox.ItemsAppearance.Parent = this.loadconfigsComboBox;
            this.loadconfigsComboBox.Location = new System.Drawing.Point(9, 220);
            this.loadconfigsComboBox.Name = "loadconfigsComboBox";
            this.loadconfigsComboBox.ShadowDecoration.Parent = this.loadconfigsComboBox;
            this.loadconfigsComboBox.Size = new System.Drawing.Size(175, 36);
            this.loadconfigsComboBox.StartIndex = 0;
            this.loadconfigsComboBox.TabIndex = 12;
            this.loadconfigsComboBox.SelectedIndexChanged += new System.EventHandler(this.loadconfigsComboBox_SelectedIndexChanged);
            this.loadconfigsComboBox.Click += new System.EventHandler(this.loadconfigsComboBox_Click);
            // 
            // chromamodeLabel
            // 
            this.chromamodeLabel.AutoSize = true;
            this.chromamodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.chromamodeLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chromamodeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.chromamodeLabel.ForeColor = System.Drawing.Color.White;
            this.chromamodeLabel.Location = new System.Drawing.Point(7, 37);
            this.chromamodeLabel.Name = "chromamodeLabel";
            this.chromamodeLabel.Size = new System.Drawing.Size(104, 20);
            this.chromamodeLabel.TabIndex = 7;
            this.chromamodeLabel.Text = "Chroma Mode";
            // 
            // chromamodeToggleSwitch
            // 
            this.chromamodeToggleSwitch.Animated = true;
            this.chromamodeToggleSwitch.BackColor = System.Drawing.Color.Transparent;
            this.chromamodeToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chromamodeToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chromamodeToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chromamodeToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.chromamodeToggleSwitch.CheckedState.Parent = this.chromamodeToggleSwitch;
            this.Transition.SetDecoration(this.chromamodeToggleSwitch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chromamodeToggleSwitch.Location = new System.Drawing.Point(150, 37);
            this.chromamodeToggleSwitch.Name = "chromamodeToggleSwitch";
            this.chromamodeToggleSwitch.ShadowDecoration.Parent = this.chromamodeToggleSwitch;
            this.chromamodeToggleSwitch.Size = new System.Drawing.Size(35, 20);
            this.chromamodeToggleSwitch.TabIndex = 6;
            this.chromamodeToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chromamodeToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chromamodeToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chromamodeToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.chromamodeToggleSwitch.UncheckedState.Parent = this.chromamodeToggleSwitch;
            this.chromamodeToggleSwitch.CheckedChanged += new System.EventHandler(this.chromamodeToggleSwitch_CheckedChanged);
            // 
            // lightmodeLabel
            // 
            this.lightmodeLabel.AutoSize = true;
            this.lightmodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.lightmodeLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lightmodeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lightmodeLabel.ForeColor = System.Drawing.Color.White;
            this.lightmodeLabel.Location = new System.Drawing.Point(7, 78);
            this.lightmodeLabel.Name = "lightmodeLabel";
            this.lightmodeLabel.Size = new System.Drawing.Size(85, 20);
            this.lightmodeLabel.TabIndex = 5;
            this.lightmodeLabel.Text = "Light Mode";
            // 
            // lightmodeToggleSwitch
            // 
            this.lightmodeToggleSwitch.Animated = true;
            this.lightmodeToggleSwitch.BackColor = System.Drawing.Color.Transparent;
            this.lightmodeToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lightmodeToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lightmodeToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.lightmodeToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.lightmodeToggleSwitch.CheckedState.Parent = this.lightmodeToggleSwitch;
            this.Transition.SetDecoration(this.lightmodeToggleSwitch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lightmodeToggleSwitch.Location = new System.Drawing.Point(150, 78);
            this.lightmodeToggleSwitch.Name = "lightmodeToggleSwitch";
            this.lightmodeToggleSwitch.ShadowDecoration.Parent = this.lightmodeToggleSwitch;
            this.lightmodeToggleSwitch.Size = new System.Drawing.Size(35, 20);
            this.lightmodeToggleSwitch.TabIndex = 0;
            this.lightmodeToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lightmodeToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lightmodeToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.lightmodeToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.lightmodeToggleSwitch.UncheckedState.Parent = this.lightmodeToggleSwitch;
            this.lightmodeToggleSwitch.CheckedChanged += new System.EventHandler(this.lightmodeToggleSwitch_CheckedChanged);
            // 
            // triggerbotoptionsGroupBox
            // 
            this.triggerbotoptionsGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.triggerbotoptionsGroupBox.BorderRadius = 8;
            this.triggerbotoptionsGroupBox.BorderThickness = 0;
            this.triggerbotoptionsGroupBox.Controls.Add(this.quickscopeLabel);
            this.triggerbotoptionsGroupBox.Controls.Add(this.quickscopeToggleSwitch);
            this.triggerbotoptionsGroupBox.Controls.Add(this.humanizationLabel);
            this.triggerbotoptionsGroupBox.Controls.Add(this.humanizeToggleSwitch);
            this.triggerbotoptionsGroupBox.Controls.Add(this.antirecoilstrengthLabel);
            this.triggerbotoptionsGroupBox.Controls.Add(this.antirecoilstrengthTrackBar);
            this.triggerbotoptionsGroupBox.Controls.Add(this.label1);
            this.triggerbotoptionsGroupBox.Controls.Add(this.antirecoilToggleSwitch);
            this.triggerbotoptionsGroupBox.Controls.Add(this.delayLabel);
            this.triggerbotoptionsGroupBox.Controls.Add(this.shotdelayTrackBar);
            this.triggerbotoptionsGroupBox.Controls.Add(this.shottysnipersLabel);
            this.triggerbotoptionsGroupBox.Controls.Add(this.shottysnipersToggleSwitch);
            this.triggerbotoptionsGroupBox.CustomBorderColor = System.Drawing.Color.BlueViolet;
            this.triggerbotoptionsGroupBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Transition.SetDecoration(this.triggerbotoptionsGroupBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.triggerbotoptionsGroupBox.FillColor = System.Drawing.Color.Indigo;
            this.triggerbotoptionsGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triggerbotoptionsGroupBox.ForeColor = System.Drawing.Color.White;
            this.triggerbotoptionsGroupBox.Location = new System.Drawing.Point(338, 68);
            this.triggerbotoptionsGroupBox.Name = "triggerbotoptionsGroupBox";
            this.triggerbotoptionsGroupBox.ShadowDecoration.Parent = this.triggerbotoptionsGroupBox;
            this.triggerbotoptionsGroupBox.Size = new System.Drawing.Size(192, 280);
            this.triggerbotoptionsGroupBox.TabIndex = 4;
            this.triggerbotoptionsGroupBox.Text = "Triggerbot Options";
            this.triggerbotoptionsGroupBox.TextOffset = new System.Drawing.Point(0, -5);
            this.triggerbotoptionsGroupBox.Visible = false;
            // 
            // quickscopeLabel
            // 
            this.quickscopeLabel.AutoSize = true;
            this.quickscopeLabel.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.quickscopeLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.quickscopeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.quickscopeLabel.ForeColor = System.Drawing.Color.White;
            this.quickscopeLabel.Location = new System.Drawing.Point(7, 73);
            this.quickscopeLabel.Name = "quickscopeLabel";
            this.quickscopeLabel.Size = new System.Drawing.Size(85, 20);
            this.quickscopeLabel.TabIndex = 18;
            this.quickscopeLabel.Text = "Quickscope";
            // 
            // quickscopeToggleSwitch
            // 
            this.quickscopeToggleSwitch.Animated = true;
            this.quickscopeToggleSwitch.BackColor = System.Drawing.Color.Transparent;
            this.quickscopeToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quickscopeToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quickscopeToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.quickscopeToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.quickscopeToggleSwitch.CheckedState.Parent = this.quickscopeToggleSwitch;
            this.Transition.SetDecoration(this.quickscopeToggleSwitch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.quickscopeToggleSwitch.Location = new System.Drawing.Point(149, 73);
            this.quickscopeToggleSwitch.Name = "quickscopeToggleSwitch";
            this.quickscopeToggleSwitch.ShadowDecoration.Parent = this.quickscopeToggleSwitch;
            this.quickscopeToggleSwitch.Size = new System.Drawing.Size(35, 20);
            this.quickscopeToggleSwitch.TabIndex = 17;
            this.quickscopeToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.quickscopeToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.quickscopeToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.quickscopeToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.quickscopeToggleSwitch.UncheckedState.Parent = this.quickscopeToggleSwitch;
            this.quickscopeToggleSwitch.CheckedChanged += new System.EventHandler(this.quickscopeToggleSwitch_CheckedChanged);
            // 
            // humanizationLabel
            // 
            this.humanizationLabel.AutoSize = true;
            this.humanizationLabel.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.humanizationLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.humanizationLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.humanizationLabel.ForeColor = System.Drawing.Color.White;
            this.humanizationLabel.Location = new System.Drawing.Point(7, 107);
            this.humanizationLabel.Name = "humanizationLabel";
            this.humanizationLabel.Size = new System.Drawing.Size(102, 20);
            this.humanizationLabel.TabIndex = 12;
            this.humanizationLabel.Text = "Humanization";
            // 
            // humanizeToggleSwitch
            // 
            this.humanizeToggleSwitch.Animated = true;
            this.humanizeToggleSwitch.BackColor = System.Drawing.Color.Transparent;
            this.humanizeToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.humanizeToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.humanizeToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.humanizeToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.humanizeToggleSwitch.CheckedState.Parent = this.humanizeToggleSwitch;
            this.Transition.SetDecoration(this.humanizeToggleSwitch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.humanizeToggleSwitch.Location = new System.Drawing.Point(149, 107);
            this.humanizeToggleSwitch.Name = "humanizeToggleSwitch";
            this.humanizeToggleSwitch.ShadowDecoration.Parent = this.humanizeToggleSwitch;
            this.humanizeToggleSwitch.Size = new System.Drawing.Size(35, 20);
            this.humanizeToggleSwitch.TabIndex = 11;
            this.humanizeToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.humanizeToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.humanizeToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.humanizeToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.humanizeToggleSwitch.UncheckedState.Parent = this.humanizeToggleSwitch;
            this.humanizeToggleSwitch.CheckedChanged += new System.EventHandler(this.humanizeToggleSwitch_CheckedChanged);
            // 
            // antirecoilstrengthLabel
            // 
            this.antirecoilstrengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.antirecoilstrengthLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.antirecoilstrengthLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antirecoilstrengthLabel.ForeColor = System.Drawing.Color.White;
            this.antirecoilstrengthLabel.Location = new System.Drawing.Point(3, 233);
            this.antirecoilstrengthLabel.Name = "antirecoilstrengthLabel";
            this.antirecoilstrengthLabel.Size = new System.Drawing.Size(193, 21);
            this.antirecoilstrengthLabel.TabIndex = 16;
            this.antirecoilstrengthLabel.Text = "Anti-Recoil Strength: 0";
            // 
            // antirecoilstrengthTrackBar
            // 
            this.Transition.SetDecoration(this.antirecoilstrengthTrackBar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.antirecoilstrengthTrackBar.HoverState.Parent = this.antirecoilstrengthTrackBar;
            this.antirecoilstrengthTrackBar.Location = new System.Drawing.Point(3, 257);
            this.antirecoilstrengthTrackBar.Name = "antirecoilstrengthTrackBar";
            this.antirecoilstrengthTrackBar.Size = new System.Drawing.Size(181, 19);
            this.antirecoilstrengthTrackBar.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.antirecoilstrengthTrackBar.TabIndex = 15;
            this.antirecoilstrengthTrackBar.ThumbColor = System.Drawing.Color.DarkSlateBlue;
            this.antirecoilstrengthTrackBar.Value = 0;
            this.antirecoilstrengthTrackBar.ValueChanged += new System.EventHandler(this.antirecoilstrengthTrackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Anti-Recoil";
            // 
            // antirecoilToggleSwitch
            // 
            this.antirecoilToggleSwitch.Animated = true;
            this.antirecoilToggleSwitch.BackColor = System.Drawing.Color.Transparent;
            this.antirecoilToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.antirecoilToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.antirecoilToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.antirecoilToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.antirecoilToggleSwitch.CheckedState.Parent = this.antirecoilToggleSwitch;
            this.Transition.SetDecoration(this.antirecoilToggleSwitch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.antirecoilToggleSwitch.Location = new System.Drawing.Point(149, 141);
            this.antirecoilToggleSwitch.Name = "antirecoilToggleSwitch";
            this.antirecoilToggleSwitch.ShadowDecoration.Parent = this.antirecoilToggleSwitch;
            this.antirecoilToggleSwitch.Size = new System.Drawing.Size(35, 20);
            this.antirecoilToggleSwitch.TabIndex = 9;
            this.antirecoilToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.antirecoilToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.antirecoilToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.antirecoilToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.antirecoilToggleSwitch.UncheckedState.Parent = this.antirecoilToggleSwitch;
            this.antirecoilToggleSwitch.CheckedChanged += new System.EventHandler(this.antirecoilToggleSwitch_CheckedChanged);
            // 
            // delayLabel
            // 
            this.delayLabel.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.delayLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.delayLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.delayLabel.ForeColor = System.Drawing.Color.White;
            this.delayLabel.Location = new System.Drawing.Point(3, 183);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(157, 21);
            this.delayLabel.TabIndex = 6;
            this.delayLabel.Text = "Shot Delay: 0ms";
            // 
            // shotdelayTrackBar
            // 
            this.Transition.SetDecoration(this.shotdelayTrackBar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.shotdelayTrackBar.HoverState.Parent = this.shotdelayTrackBar;
            this.shotdelayTrackBar.Location = new System.Drawing.Point(3, 207);
            this.shotdelayTrackBar.Maximum = 500;
            this.shotdelayTrackBar.Name = "shotdelayTrackBar";
            this.shotdelayTrackBar.Size = new System.Drawing.Size(181, 19);
            this.shotdelayTrackBar.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.shotdelayTrackBar.TabIndex = 0;
            this.shotdelayTrackBar.ThumbColor = System.Drawing.Color.DarkSlateBlue;
            this.shotdelayTrackBar.Value = 0;
            this.shotdelayTrackBar.ValueChanged += new System.EventHandler(this.shotdelayTrackBar_ValueChanged);
            // 
            // shottysnipersLabel
            // 
            this.shottysnipersLabel.AutoSize = true;
            this.shottysnipersLabel.BackColor = System.Drawing.Color.Transparent;
            this.Transition.SetDecoration(this.shottysnipersLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.shottysnipersLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.shottysnipersLabel.ForeColor = System.Drawing.Color.White;
            this.shottysnipersLabel.Location = new System.Drawing.Point(7, 39);
            this.shottysnipersLabel.Name = "shottysnipersLabel";
            this.shottysnipersLabel.Size = new System.Drawing.Size(103, 20);
            this.shottysnipersLabel.TabIndex = 8;
            this.shottysnipersLabel.Text = "Shotty Snipers";
            // 
            // shottysnipersToggleSwitch
            // 
            this.shottysnipersToggleSwitch.Animated = true;
            this.shottysnipersToggleSwitch.BackColor = System.Drawing.Color.Transparent;
            this.shottysnipersToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shottysnipersToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.shottysnipersToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.shottysnipersToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.shottysnipersToggleSwitch.CheckedState.Parent = this.shottysnipersToggleSwitch;
            this.Transition.SetDecoration(this.shottysnipersToggleSwitch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.shottysnipersToggleSwitch.Location = new System.Drawing.Point(149, 39);
            this.shottysnipersToggleSwitch.Name = "shottysnipersToggleSwitch";
            this.shottysnipersToggleSwitch.ShadowDecoration.Parent = this.shottysnipersToggleSwitch;
            this.shottysnipersToggleSwitch.Size = new System.Drawing.Size(35, 20);
            this.shottysnipersToggleSwitch.TabIndex = 7;
            this.shottysnipersToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.shottysnipersToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.shottysnipersToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.shottysnipersToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.shottysnipersToggleSwitch.UncheckedState.Parent = this.shottysnipersToggleSwitch;
            this.shottysnipersToggleSwitch.CheckedChanged += new System.EventHandler(this.shottysnipersToggleSwitch_CheckedChanged);
            // 
            // ChromamodeTimer
            // 
            this.ChromamodeTimer.Tick += new System.EventHandler(this.ChromamodeTimer_Tick);
            // 
            // Transition
            // 
            this.Transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.Transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.Transition.DefaultAnimation = animation1;
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.Transition.SetDecoration(this.subLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.subLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLabel.ForeColor = System.Drawing.Color.White;
            this.subLabel.Location = new System.Drawing.Point(4, 393);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(100, 21);
            this.subLabel.TabIndex = 5;
            this.subLabel.Text = "Subscription:";
            this.subLabel.Visible = false;
            // 
            // humanizationTimer
            // 
            this.humanizationTimer.Tick += new System.EventHandler(this.humanizationTimer_Tick);
            // 
            // motdLabel
            // 
            this.motdLabel.AutoSize = true;
            this.Transition.SetDecoration(this.motdLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.motdLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motdLabel.ForeColor = System.Drawing.Color.White;
            this.motdLabel.Location = new System.Drawing.Point(4, 414);
            this.motdLabel.Name = "motdLabel";
            this.motdLabel.Size = new System.Drawing.Size(57, 21);
            this.motdLabel.TabIndex = 6;
            this.motdLabel.Text = "MOTD:";
            this.motdLabel.Visible = false;
            // 
            // SploitGate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 437);
            this.Controls.Add(this.motdLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.miscGroupBox);
            this.Controls.Add(this.triggerbotoptionsGroupBox);
            this.Controls.Add(this.triggerbotGroupBox);
            this.Controls.Add(this.welcomeLabel);
            this.Transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MaximizeBox = false;
            this.Name = "SploitGate";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Sploitgate v2.6";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SploitGate_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            this.triggerbotGroupBox.ResumeLayout(false);
            this.triggerbotGroupBox.PerformLayout();
            this.miscGroupBox.ResumeLayout(false);
            this.miscGroupBox.PerformLayout();
            this.triggerbotoptionsGroupBox.ResumeLayout(false);
            this.triggerbotoptionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager StyleManager;
        private System.Windows.Forms.Label welcomeLabel;
        private Guna.UI2.WinForms.Guna2GroupBox triggerbotGroupBox;
        private Guna.UI2.WinForms.Guna2GroupBox miscGroupBox;
        private Guna.UI2.WinForms.Guna2GroupBox triggerbotoptionsGroupBox;
        private System.Windows.Forms.Label lightmodeLabel;
        private System.Windows.Forms.Label delayLabel;
        private Guna.UI2.WinForms.Guna2TrackBar shotdelayTrackBar;
        private System.Windows.Forms.Label shottysnipersLabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch shottysnipersToggleSwitch;
        private System.Windows.Forms.Label chromamodeLabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch chromamodeToggleSwitch;
        private System.Windows.Forms.Label triggerLabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch triggerbotToggleSwitch;
        public Guna.UI2.WinForms.Guna2ToggleSwitch lightmodeToggleSwitch;
        private System.Windows.Forms.Timer ChromamodeTimer;
        private Guna.UI2.WinForms.Guna2Button configsaveButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch antirecoilToggleSwitch;
        private Guna.UI2.WinForms.Guna2Transition Transition;
        private Guna.UI2.WinForms.Guna2ComboBox loadconfigsComboBox;
        private System.Windows.Forms.Label rightclickLabel;
        public Guna.UI2.WinForms.Guna2ToggleSwitch rightclickToggleSwitch;
        private System.Windows.Forms.Label antirecoilstrengthLabel;
        private Guna.UI2.WinForms.Guna2TrackBar antirecoilstrengthTrackBar;
        private System.Windows.Forms.Label humanizationLabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch humanizeToggleSwitch;
        private System.Windows.Forms.Timer humanizationTimer;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label quickscopeLabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch quickscopeToggleSwitch;
        private System.Windows.Forms.Label motdLabel;
    }
}

