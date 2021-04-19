
namespace CalendarProject
{
    partial class Form1
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.mainMenu = new System.Windows.Forms.TableLayoutPanel();
            this.addEventButton = new System.Windows.Forms.Button();
            this.deleteEventButton = new System.Windows.Forms.Button();
            this.editEventButton = new System.Windows.Forms.Button();
            this.monthlyListButton = new System.Windows.Forms.Button();
            this.viewEventButton = new System.Windows.Forms.Button();
            this.managerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addManagerEvent = new System.Windows.Forms.Button();
            this.deleteManagerEvent = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogIn12345tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logIn67890tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button1Pin = new System.Windows.Forms.Button();
            this.button2Pin = new System.Windows.Forms.Button();
            this.button3Pin = new System.Windows.Forms.Button();
            this.button4Pin = new System.Windows.Forms.Button();
            this.button5Pin = new System.Windows.Forms.Button();
            this.button6Pin = new System.Windows.Forms.Button();
            this.button7Pin = new System.Windows.Forms.Button();
            this.button8Pin = new System.Windows.Forms.Button();
            this.button9Pin = new System.Windows.Forms.Button();
            this.button0Pin = new System.Windows.Forms.Button();
            this.PintableLayoutPanelDeleteClear = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDeletePin = new System.Windows.Forms.Button();
            this.buttonClearPin = new System.Windows.Forms.Button();
            this.buttonProcessPin = new System.Windows.Forms.Button();
            this.buttonCancelPin = new System.Windows.Forms.Button();
            this.errorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.errorButton = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.managerTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.LogIn12345tableLayoutPanel.SuspendLayout();
            this.logIn67890tableLayoutPanel.SuspendLayout();
            this.PintableLayoutPanelDeleteClear.SuspendLayout();
            this.errorTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // mainMenu
            // 
            this.mainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenu.ColumnCount = 1;
            this.mainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainMenu.Controls.Add(this.addEventButton, 0, 1);
            this.mainMenu.Controls.Add(this.deleteEventButton, 0, 2);
            this.mainMenu.Controls.Add(this.editEventButton, 0, 3);
            this.mainMenu.Controls.Add(this.monthlyListButton, 0, 4);
            this.mainMenu.Controls.Add(this.viewEventButton, 0, 0);
            this.mainMenu.Location = new System.Drawing.Point(383, 3);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RowCount = 5;
            this.mainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainMenu.Size = new System.Drawing.Size(374, 299);
            this.mainMenu.TabIndex = 1;
            // 
            // addEventButton
            // 
            this.addEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addEventButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addEventButton.Location = new System.Drawing.Point(3, 62);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(368, 53);
            this.addEventButton.TabIndex = 1;
            this.addEventButton.Text = "Add Event";
            this.addEventButton.UseVisualStyleBackColor = false;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // deleteEventButton
            // 
            this.deleteEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteEventButton.BackColor = System.Drawing.Color.Purple;
            this.deleteEventButton.Location = new System.Drawing.Point(3, 121);
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Size = new System.Drawing.Size(368, 53);
            this.deleteEventButton.TabIndex = 2;
            this.deleteEventButton.Text = "Delete Button";
            this.deleteEventButton.UseVisualStyleBackColor = false;
            this.deleteEventButton.Click += new System.EventHandler(this.deleteEventButton_Click);
            // 
            // editEventButton
            // 
            this.editEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editEventButton.BackColor = System.Drawing.Color.Magenta;
            this.editEventButton.Location = new System.Drawing.Point(3, 180);
            this.editEventButton.Name = "editEventButton";
            this.editEventButton.Size = new System.Drawing.Size(368, 53);
            this.editEventButton.TabIndex = 3;
            this.editEventButton.Text = "Edit Event";
            this.editEventButton.UseVisualStyleBackColor = false;
            // 
            // monthlyListButton
            // 
            this.monthlyListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthlyListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.monthlyListButton.Location = new System.Drawing.Point(3, 239);
            this.monthlyListButton.Name = "monthlyListButton";
            this.monthlyListButton.Size = new System.Drawing.Size(368, 57);
            this.monthlyListButton.TabIndex = 4;
            this.monthlyListButton.Text = "View Monthly-Based List";
            this.monthlyListButton.UseVisualStyleBackColor = false;
            // 
            // viewEventButton
            // 
            this.viewEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewEventButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.viewEventButton.Location = new System.Drawing.Point(3, 3);
            this.viewEventButton.Name = "viewEventButton";
            this.viewEventButton.Size = new System.Drawing.Size(368, 53);
            this.viewEventButton.TabIndex = 0;
            this.viewEventButton.Text = "View Event";
            this.viewEventButton.UseVisualStyleBackColor = false;
            this.viewEventButton.Click += new System.EventHandler(this.viewEventButton_Click);
            // 
            // managerTableLayoutPanel
            // 
            this.managerTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managerTableLayoutPanel.ColumnCount = 1;
            this.managerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.managerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.managerTableLayoutPanel.Controls.Add(this.addManagerEvent, 0, 0);
            this.managerTableLayoutPanel.Controls.Add(this.deleteManagerEvent, 0, 1);
            this.managerTableLayoutPanel.Location = new System.Drawing.Point(3, 308);
            this.managerTableLayoutPanel.Name = "managerTableLayoutPanel";
            this.managerTableLayoutPanel.RowCount = 2;
            this.managerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.managerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.managerTableLayoutPanel.Size = new System.Drawing.Size(374, 112);
            this.managerTableLayoutPanel.TabIndex = 2;
            // 
            // addManagerEvent
            // 
            this.addManagerEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addManagerEvent.BackColor = System.Drawing.Color.Lime;
            this.addManagerEvent.Location = new System.Drawing.Point(3, 3);
            this.addManagerEvent.Name = "addManagerEvent";
            this.addManagerEvent.Size = new System.Drawing.Size(368, 50);
            this.addManagerEvent.TabIndex = 0;
            this.addManagerEvent.Text = "Add Manager Event";
            this.addManagerEvent.UseVisualStyleBackColor = false;
            // 
            // deleteManagerEvent
            // 
            this.deleteManagerEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteManagerEvent.BackColor = System.Drawing.Color.Lime;
            this.deleteManagerEvent.Location = new System.Drawing.Point(3, 59);
            this.deleteManagerEvent.Name = "deleteManagerEvent";
            this.deleteManagerEvent.Size = new System.Drawing.Size(368, 50);
            this.deleteManagerEvent.TabIndex = 1;
            this.deleteManagerEvent.Text = "Delete Manager Event";
            this.deleteManagerEvent.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.BackColor = System.Drawing.Color.Silver;
            this.exitButton.Location = new System.Drawing.Point(553, 366);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(204, 54);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.managerTableLayoutPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mainMenu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.monthCalendar1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.exitButton, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.30047F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.69953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 423);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Beige;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonProcessPin, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.logIn67890tableLayoutPanel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LogIn12345tableLayoutPanel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.PintableLayoutPanelDeleteClear, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonCancelPin, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(776, 415);
            this.tableLayoutPanel2.TabIndex = 5;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 145);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Pin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(391, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LogIn12345tableLayoutPanel
            // 
            this.LogIn12345tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogIn12345tableLayoutPanel.ColumnCount = 5;
            this.LogIn12345tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LogIn12345tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LogIn12345tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LogIn12345tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LogIn12345tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LogIn12345tableLayoutPanel.Controls.Add(this.button5Pin, 4, 0);
            this.LogIn12345tableLayoutPanel.Controls.Add(this.button4Pin, 3, 0);
            this.LogIn12345tableLayoutPanel.Controls.Add(this.button3Pin, 2, 0);
            this.LogIn12345tableLayoutPanel.Controls.Add(this.button2Pin, 1, 0);
            this.LogIn12345tableLayoutPanel.Controls.Add(this.button1Pin, 0, 0);
            this.LogIn12345tableLayoutPanel.Location = new System.Drawing.Point(3, 148);
            this.LogIn12345tableLayoutPanel.Name = "LogIn12345tableLayoutPanel";
            this.LogIn12345tableLayoutPanel.RowCount = 1;
            this.LogIn12345tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LogIn12345tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LogIn12345tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LogIn12345tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LogIn12345tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LogIn12345tableLayoutPanel.Size = new System.Drawing.Size(382, 97);
            this.LogIn12345tableLayoutPanel.TabIndex = 2;
            // 
            // logIn67890tableLayoutPanel
            // 
            this.logIn67890tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logIn67890tableLayoutPanel.ColumnCount = 5;
            this.logIn67890tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.logIn67890tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.logIn67890tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.logIn67890tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.logIn67890tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.logIn67890tableLayoutPanel.Controls.Add(this.button0Pin, 4, 0);
            this.logIn67890tableLayoutPanel.Controls.Add(this.button6Pin, 0, 0);
            this.logIn67890tableLayoutPanel.Controls.Add(this.button7Pin, 1, 0);
            this.logIn67890tableLayoutPanel.Controls.Add(this.button9Pin, 3, 0);
            this.logIn67890tableLayoutPanel.Controls.Add(this.button8Pin, 2, 0);
            this.logIn67890tableLayoutPanel.Location = new System.Drawing.Point(391, 148);
            this.logIn67890tableLayoutPanel.Name = "logIn67890tableLayoutPanel";
            this.logIn67890tableLayoutPanel.RowCount = 1;
            this.logIn67890tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.logIn67890tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.logIn67890tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.logIn67890tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.logIn67890tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.logIn67890tableLayoutPanel.Size = new System.Drawing.Size(382, 97);
            this.logIn67890tableLayoutPanel.TabIndex = 3;
            // 
            // button1Pin
            // 
            this.button1Pin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1Pin.BackColor = System.Drawing.Color.Thistle;
            this.button1Pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1Pin.Location = new System.Drawing.Point(3, 3);
            this.button1Pin.Name = "button1Pin";
            this.button1Pin.Size = new System.Drawing.Size(70, 91);
            this.button1Pin.TabIndex = 0;
            this.button1Pin.Text = "1";
            this.button1Pin.UseVisualStyleBackColor = false;
            this.button1Pin.Click += new System.EventHandler(this.button1Pin_Click);
            // 
            // button2Pin
            // 
            this.button2Pin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2Pin.BackColor = System.Drawing.Color.Thistle;
            this.button2Pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2Pin.Location = new System.Drawing.Point(79, 3);
            this.button2Pin.Name = "button2Pin";
            this.button2Pin.Size = new System.Drawing.Size(70, 91);
            this.button2Pin.TabIndex = 1;
            this.button2Pin.Text = "2";
            this.button2Pin.UseVisualStyleBackColor = false;
            this.button2Pin.Click += new System.EventHandler(this.button2Pin_Click);
            // 
            // button3Pin
            // 
            this.button3Pin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3Pin.BackColor = System.Drawing.Color.Thistle;
            this.button3Pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button3Pin.Location = new System.Drawing.Point(155, 3);
            this.button3Pin.Name = "button3Pin";
            this.button3Pin.Size = new System.Drawing.Size(70, 91);
            this.button3Pin.TabIndex = 2;
            this.button3Pin.Text = "3";
            this.button3Pin.UseVisualStyleBackColor = false;
            this.button3Pin.Click += new System.EventHandler(this.button3Pin_Click);
            // 
            // button4Pin
            // 
            this.button4Pin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4Pin.BackColor = System.Drawing.Color.Thistle;
            this.button4Pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button4Pin.Location = new System.Drawing.Point(231, 3);
            this.button4Pin.Name = "button4Pin";
            this.button4Pin.Size = new System.Drawing.Size(70, 91);
            this.button4Pin.TabIndex = 3;
            this.button4Pin.Text = "4";
            this.button4Pin.UseVisualStyleBackColor = false;
            this.button4Pin.Click += new System.EventHandler(this.button4Pin_Click);
            // 
            // button5Pin
            // 
            this.button5Pin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5Pin.BackColor = System.Drawing.Color.Thistle;
            this.button5Pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button5Pin.Location = new System.Drawing.Point(307, 3);
            this.button5Pin.Name = "button5Pin";
            this.button5Pin.Size = new System.Drawing.Size(72, 91);
            this.button5Pin.TabIndex = 4;
            this.button5Pin.Text = "5";
            this.button5Pin.UseVisualStyleBackColor = false;
            this.button5Pin.Click += new System.EventHandler(this.button5Pin_Click);
            // 
            // button6Pin
            // 
            this.button6Pin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6Pin.BackColor = System.Drawing.Color.Thistle;
            this.button6Pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button6Pin.Location = new System.Drawing.Point(3, 3);
            this.button6Pin.Name = "button6Pin";
            this.button6Pin.Size = new System.Drawing.Size(70, 91);
            this.button6Pin.TabIndex = 1;
            this.button6Pin.Text = "6";
            this.button6Pin.UseVisualStyleBackColor = false;
            this.button6Pin.Click += new System.EventHandler(this.button6Pin_Click);
            // 
            // button7Pin
            // 
            this.button7Pin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7Pin.BackColor = System.Drawing.Color.Thistle;
            this.button7Pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button7Pin.Location = new System.Drawing.Point(79, 3);
            this.button7Pin.Name = "button7Pin";
            this.button7Pin.Size = new System.Drawing.Size(70, 91);
            this.button7Pin.TabIndex = 2;
            this.button7Pin.Text = "7";
            this.button7Pin.UseVisualStyleBackColor = false;
            this.button7Pin.Click += new System.EventHandler(this.button7Pin_Click);
            // 
            // button8Pin
            // 
            this.button8Pin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8Pin.BackColor = System.Drawing.Color.Thistle;
            this.button8Pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button8Pin.Location = new System.Drawing.Point(155, 3);
            this.button8Pin.Name = "button8Pin";
            this.button8Pin.Size = new System.Drawing.Size(70, 91);
            this.button8Pin.TabIndex = 3;
            this.button8Pin.Text = "8";
            this.button8Pin.UseVisualStyleBackColor = false;
            this.button8Pin.Click += new System.EventHandler(this.button8Pin_Click);
            // 
            // button9Pin
            // 
            this.button9Pin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button9Pin.BackColor = System.Drawing.Color.Thistle;
            this.button9Pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button9Pin.Location = new System.Drawing.Point(231, 3);
            this.button9Pin.Name = "button9Pin";
            this.button9Pin.Size = new System.Drawing.Size(70, 91);
            this.button9Pin.TabIndex = 4;
            this.button9Pin.Text = "9";
            this.button9Pin.UseVisualStyleBackColor = false;
            this.button9Pin.Click += new System.EventHandler(this.button9Pin_Click);
            // 
            // button0Pin
            // 
            this.button0Pin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button0Pin.BackColor = System.Drawing.Color.Thistle;
            this.button0Pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button0Pin.Location = new System.Drawing.Point(307, 3);
            this.button0Pin.Name = "button0Pin";
            this.button0Pin.Size = new System.Drawing.Size(72, 91);
            this.button0Pin.TabIndex = 5;
            this.button0Pin.Text = "0";
            this.button0Pin.UseVisualStyleBackColor = false;
            this.button0Pin.Click += new System.EventHandler(this.button0Pin_Click);
            // 
            // PintableLayoutPanelDeleteClear
            // 
            this.PintableLayoutPanelDeleteClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PintableLayoutPanelDeleteClear.ColumnCount = 2;
            this.PintableLayoutPanelDeleteClear.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PintableLayoutPanelDeleteClear.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PintableLayoutPanelDeleteClear.Controls.Add(this.buttonClearPin, 1, 0);
            this.PintableLayoutPanelDeleteClear.Controls.Add(this.buttonDeletePin, 0, 0);
            this.PintableLayoutPanelDeleteClear.Location = new System.Drawing.Point(3, 251);
            this.PintableLayoutPanelDeleteClear.Name = "PintableLayoutPanelDeleteClear";
            this.PintableLayoutPanelDeleteClear.RowCount = 1;
            this.PintableLayoutPanelDeleteClear.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PintableLayoutPanelDeleteClear.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PintableLayoutPanelDeleteClear.Size = new System.Drawing.Size(382, 77);
            this.PintableLayoutPanelDeleteClear.TabIndex = 4;
            // 
            // buttonDeletePin
            // 
            this.buttonDeletePin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeletePin.BackColor = System.Drawing.Color.Plum;
            this.buttonDeletePin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.buttonDeletePin.Location = new System.Drawing.Point(3, 3);
            this.buttonDeletePin.Name = "buttonDeletePin";
            this.buttonDeletePin.Size = new System.Drawing.Size(185, 71);
            this.buttonDeletePin.TabIndex = 0;
            this.buttonDeletePin.Text = "Delete";
            this.buttonDeletePin.UseVisualStyleBackColor = false;
            this.buttonDeletePin.Click += new System.EventHandler(this.buttonDeletePin_Click);
            // 
            // buttonClearPin
            // 
            this.buttonClearPin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearPin.BackColor = System.Drawing.Color.Violet;
            this.buttonClearPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.buttonClearPin.Location = new System.Drawing.Point(194, 3);
            this.buttonClearPin.Name = "buttonClearPin";
            this.buttonClearPin.Size = new System.Drawing.Size(185, 71);
            this.buttonClearPin.TabIndex = 1;
            this.buttonClearPin.Text = "Clear All";
            this.buttonClearPin.UseVisualStyleBackColor = false;
            this.buttonClearPin.Click += new System.EventHandler(this.buttonClearPin_Click);
            // 
            // buttonProcessPin
            // 
            this.buttonProcessPin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcessPin.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonProcessPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.buttonProcessPin.Location = new System.Drawing.Point(391, 251);
            this.buttonProcessPin.Name = "buttonProcessPin";
            this.buttonProcessPin.Size = new System.Drawing.Size(382, 77);
            this.buttonProcessPin.TabIndex = 5;
            this.buttonProcessPin.Text = "Process";
            this.buttonProcessPin.UseVisualStyleBackColor = false;
            this.buttonProcessPin.Click += new System.EventHandler(this.buttonProcessPin_Click);
            // 
            // buttonCancelPin
            // 
            this.buttonCancelPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelPin.BackColor = System.Drawing.Color.Thistle;
            this.buttonCancelPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.buttonCancelPin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCancelPin.Location = new System.Drawing.Point(391, 346);
            this.buttonCancelPin.Name = "buttonCancelPin";
            this.buttonCancelPin.Size = new System.Drawing.Size(382, 54);
            this.buttonCancelPin.TabIndex = 6;
            this.buttonCancelPin.Text = "Cancel";
            this.buttonCancelPin.UseVisualStyleBackColor = false;
            this.buttonCancelPin.Click += new System.EventHandler(this.buttonCancelPin_Click);
            // 
            // errorTableLayoutPanel
            // 
            this.errorTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorTableLayoutPanel.BackColor = System.Drawing.Color.Crimson;
            this.errorTableLayoutPanel.ColumnCount = 1;
            this.errorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.errorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.errorTableLayoutPanel.Controls.Add(this.errorLabel, 0, 0);
            this.errorTableLayoutPanel.Controls.Add(this.errorButton, 0, 1);
            this.errorTableLayoutPanel.Location = new System.Drawing.Point(3, 12);
            this.errorTableLayoutPanel.Name = "errorTableLayoutPanel";
            this.errorTableLayoutPanel.RowCount = 2;
            this.errorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.errorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.errorTableLayoutPanel.Size = new System.Drawing.Size(785, 426);
            this.errorTableLayoutPanel.TabIndex = 6;
            this.errorTableLayoutPanel.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.White;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.errorLabel.Location = new System.Drawing.Point(3, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(779, 213);
            this.errorLabel.TabIndex = 0;
            this.errorLabel.Text = "error Label";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorButton
            // 
            this.errorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.errorButton.BackColor = System.Drawing.Color.IndianRed;
            this.errorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.errorButton.Location = new System.Drawing.Point(179, 216);
            this.errorButton.Name = "errorButton";
            this.errorButton.Size = new System.Drawing.Size(426, 207);
            this.errorButton.TabIndex = 1;
            this.errorButton.Text = "okay";
            this.errorButton.UseVisualStyleBackColor = false;
            this.errorButton.Click += new System.EventHandler(this.errorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.errorTableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenu.ResumeLayout(false);
            this.managerTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.LogIn12345tableLayoutPanel.ResumeLayout(false);
            this.logIn67890tableLayoutPanel.ResumeLayout(false);
            this.PintableLayoutPanelDeleteClear.ResumeLayout(false);
            this.errorTableLayoutPanel.ResumeLayout(false);
            this.errorTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TableLayoutPanel mainMenu;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Button deleteEventButton;
        private System.Windows.Forms.Button viewEventButton;
        private System.Windows.Forms.Button editEventButton;
        private System.Windows.Forms.Button monthlyListButton;
        private System.Windows.Forms.TableLayoutPanel managerTableLayoutPanel;
        private System.Windows.Forms.Button addManagerEvent;
        private System.Windows.Forms.Button deleteManagerEvent;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel LogIn12345tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel logIn67890tableLayoutPanel;
        private System.Windows.Forms.Button button1Pin;
        private System.Windows.Forms.Button buttonProcessPin;
        private System.Windows.Forms.Button button0Pin;
        private System.Windows.Forms.Button button8Pin;
        private System.Windows.Forms.Button button7Pin;
        private System.Windows.Forms.Button button6Pin;
        private System.Windows.Forms.Button button9Pin;
        private System.Windows.Forms.Button button5Pin;
        private System.Windows.Forms.Button button4Pin;
        private System.Windows.Forms.Button button3Pin;
        private System.Windows.Forms.Button button2Pin;
        private System.Windows.Forms.TableLayoutPanel PintableLayoutPanelDeleteClear;
        private System.Windows.Forms.Button buttonClearPin;
        private System.Windows.Forms.Button buttonDeletePin;
        private System.Windows.Forms.Button buttonCancelPin;
        private System.Windows.Forms.TableLayoutPanel errorTableLayoutPanel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button errorButton;
    }
}

