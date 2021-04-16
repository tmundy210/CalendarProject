
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
            this.viewEventButton = new System.Windows.Forms.Button();
            this.addEventButton = new System.Windows.Forms.Button();
            this.deleteEventButton = new System.Windows.Forms.Button();
            this.editEventButton = new System.Windows.Forms.Button();
            this.monthlyListButton = new System.Windows.Forms.Button();
            this.managerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addManagerEvent = new System.Windows.Forms.Button();
            this.deleteManagerEvent = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.managerTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(21, 15);
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
            this.mainMenu.Location = new System.Drawing.Point(407, 15);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RowCount = 5;
            this.mainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainMenu.Size = new System.Drawing.Size(352, 414);
            this.mainMenu.TabIndex = 1;
            // 
            // viewEventButton
            // 
            this.viewEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewEventButton.Location = new System.Drawing.Point(3, 3);
            this.viewEventButton.Name = "viewEventButton";
            this.viewEventButton.Size = new System.Drawing.Size(346, 76);
            this.viewEventButton.TabIndex = 0;
            this.viewEventButton.Text = "View Event";
            this.viewEventButton.UseVisualStyleBackColor = true;
            this.viewEventButton.Click += new System.EventHandler(this.viewEventButton_Click);
            // 
            // addEventButton
            // 
            this.addEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addEventButton.Location = new System.Drawing.Point(3, 85);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(346, 76);
            this.addEventButton.TabIndex = 1;
            this.addEventButton.Text = "Add Event";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // deleteEventButton
            // 
            this.deleteEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteEventButton.Location = new System.Drawing.Point(3, 167);
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Size = new System.Drawing.Size(346, 76);
            this.deleteEventButton.TabIndex = 2;
            this.deleteEventButton.Text = "Delete Button";
            this.deleteEventButton.UseVisualStyleBackColor = true;
            this.deleteEventButton.Click += new System.EventHandler(this.deleteEventButton_Click);
            // 
            // editEventButton
            // 
            this.editEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editEventButton.Location = new System.Drawing.Point(3, 249);
            this.editEventButton.Name = "editEventButton";
            this.editEventButton.Size = new System.Drawing.Size(346, 76);
            this.editEventButton.TabIndex = 3;
            this.editEventButton.Text = "Edit Event";
            this.editEventButton.UseVisualStyleBackColor = true;
            // 
            // monthlyListButton
            // 
            this.monthlyListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthlyListButton.Location = new System.Drawing.Point(3, 331);
            this.monthlyListButton.Name = "monthlyListButton";
            this.monthlyListButton.Size = new System.Drawing.Size(346, 80);
            this.monthlyListButton.TabIndex = 4;
            this.monthlyListButton.Text = "View Monthly-Based List";
            this.monthlyListButton.UseVisualStyleBackColor = true;
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
            this.managerTableLayoutPanel.Location = new System.Drawing.Point(18, 237);
            this.managerTableLayoutPanel.Name = "managerTableLayoutPanel";
            this.managerTableLayoutPanel.RowCount = 2;
            this.managerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.managerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.managerTableLayoutPanel.Size = new System.Drawing.Size(327, 186);
            this.managerTableLayoutPanel.TabIndex = 2;
            // 
            // addManagerEvent
            // 
            this.addManagerEvent.Location = new System.Drawing.Point(3, 3);
            this.addManagerEvent.Name = "addManagerEvent";
            this.addManagerEvent.Size = new System.Drawing.Size(321, 87);
            this.addManagerEvent.TabIndex = 0;
            this.addManagerEvent.Text = "Add Manager Event";
            this.addManagerEvent.UseVisualStyleBackColor = true;
            // 
            // deleteManagerEvent
            // 
            this.deleteManagerEvent.Location = new System.Drawing.Point(3, 96);
            this.deleteManagerEvent.Name = "deleteManagerEvent";
            this.deleteManagerEvent.Size = new System.Drawing.Size(321, 87);
            this.deleteManagerEvent.TabIndex = 1;
            this.deleteManagerEvent.Text = "Delete Manager Event";
            this.deleteManagerEvent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.managerTableLayoutPanel);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainMenu.ResumeLayout(false);
            this.managerTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}

