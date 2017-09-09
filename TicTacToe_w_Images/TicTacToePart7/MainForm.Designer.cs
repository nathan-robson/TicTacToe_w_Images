namespace CS_Game_Surface_w_Buttons
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoComputer = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gameCellControl1 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl2 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl3 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl4 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl5 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl6 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl7 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl8 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl9 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl10 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl11 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl12 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl13 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl14 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl15 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl16 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl17 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl18 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl19 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl20 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl21 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl22 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl23 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl24 = new GameCellControlNamespace.GameCellControl();
            this.gameCellControl25 = new GameCellControlNamespace.GameCellControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Human Player: ";
            // 
            // btnGoComputer
            // 
            this.btnGoComputer.Location = new System.Drawing.Point(12, 172);
            this.btnGoComputer.Name = "btnGoComputer";
            this.btnGoComputer.Size = new System.Drawing.Size(90, 60);
            this.btnGoComputer.TabIndex = 3;
            this.btnGoComputer.Text = "Go! Computer";
            this.btnGoComputer.UseVisualStyleBackColor = true;
            this.btnGoComputer.Click += new System.EventHandler(this.btnGoComputer_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(13, 106);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(90, 60);
            this.btnStartGame.TabIndex = 4;
            this.btnStartGame.Text = "Start New Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(98, 10);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(197, 20);
            this.txtPlayerName.TabIndex = 5;
            this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayername_Validated);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl9, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl10, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl12, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl13, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl14, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl15, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl16, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl17, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl18, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl19, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl20, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl21, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl22, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl23, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl24, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.gameCellControl25, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(109, 36);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(463, 463);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // gameCellControl1
            // 
            this.gameCellControl1.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl1.GameCellCol = 0;
            this.gameCellControl1.GameCellRow = 0;
            this.gameCellControl1.Location = new System.Drawing.Point(4, 4);
            this.gameCellControl1.Name = "gameCellControl1";
            this.gameCellControl1.Size = new System.Drawing.Size(85, 85);
            this.gameCellControl1.TabIndex = 0;
            this.gameCellControl1.Value = "?";
            this.gameCellControl1.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            // 
            // gameCellControl2
            // 
            this.gameCellControl2.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl2.GameCellCol = 1;
            this.gameCellControl2.GameCellRow = 0;
            this.gameCellControl2.Location = new System.Drawing.Point(96, 4);
            this.gameCellControl2.Name = "gameCellControl2";
            this.gameCellControl2.Size = new System.Drawing.Size(85, 85);
            this.gameCellControl2.TabIndex = 0;
            this.gameCellControl2.Value = "?";
            this.gameCellControl2.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            // 
            // gameCellControl3
            // 
            this.gameCellControl3.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl3.GameCellCol = 2;
            this.gameCellControl3.GameCellRow = 0;
            this.gameCellControl3.Location = new System.Drawing.Point(188, 4);
            this.gameCellControl3.Name = "gameCellControl3";
            this.gameCellControl3.Size = new System.Drawing.Size(85, 85);
            this.gameCellControl3.TabIndex = 0;
            this.gameCellControl3.Value = "?";
            this.gameCellControl3.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            // 
            // gameCellControl4
            // 
            this.gameCellControl4.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl4.GameCellCol = 3;
            this.gameCellControl4.GameCellRow = 0;
            this.gameCellControl4.Location = new System.Drawing.Point(280, 4);
            this.gameCellControl4.Name = "gameCellControl4";
            this.gameCellControl4.Size = new System.Drawing.Size(85, 85);
            this.gameCellControl4.TabIndex = 0;
            this.gameCellControl4.Value = "?";
            this.gameCellControl4.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            // 
            // gameCellControl5
            // 
            this.gameCellControl5.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl5.GameCellCol = 4;
            this.gameCellControl5.GameCellRow = 0;
            this.gameCellControl5.Location = new System.Drawing.Point(372, 4);
            this.gameCellControl5.Name = "gameCellControl5";
            this.gameCellControl5.Size = new System.Drawing.Size(87, 85);
            this.gameCellControl5.TabIndex = 0;
            this.gameCellControl5.Value = "?";
            this.gameCellControl5.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            // 
            // gameCellControl6
            // 
            this.gameCellControl6.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl6.GameCellCol = 0;
            this.gameCellControl6.GameCellRow = 1;
            this.gameCellControl6.Location = new System.Drawing.Point(4, 96);
            this.gameCellControl6.Name = "gameCellControl6";
            this.gameCellControl6.Size = new System.Drawing.Size(85, 85);
            this.gameCellControl6.TabIndex = 0;
            this.gameCellControl6.Value = "?";
            this.gameCellControl6.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl6.Load += new System.EventHandler(this.gameCellControl6_Load);
            // 
            // gameCellControl7
            // 
            this.gameCellControl7.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl7.GameCellCol = 1;
            this.gameCellControl7.GameCellRow = 1;
            this.gameCellControl7.Location = new System.Drawing.Point(96, 96);
            this.gameCellControl7.Name = "gameCellControl7";
            this.gameCellControl7.Size = new System.Drawing.Size(85, 85);
            this.gameCellControl7.TabIndex = 0;
            this.gameCellControl7.Value = "?";
            this.gameCellControl7.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl7.Load += new System.EventHandler(this.gameCellControl7_Load);
            // 
            // gameCellControl8
            // 
            this.gameCellControl8.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl8.GameCellCol = 2;
            this.gameCellControl8.GameCellRow = 1;
            this.gameCellControl8.Location = new System.Drawing.Point(188, 96);
            this.gameCellControl8.Name = "gameCellControl8";
            this.gameCellControl8.Size = new System.Drawing.Size(85, 85);
            this.gameCellControl8.TabIndex = 0;
            this.gameCellControl8.Value = "?";
            this.gameCellControl8.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl8.Load += new System.EventHandler(this.gameCellControl7_Load);
            // 
            // gameCellControl9
            // 
            this.gameCellControl9.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl9.GameCellCol = 3;
            this.gameCellControl9.GameCellRow = 1;
            this.gameCellControl9.Location = new System.Drawing.Point(280, 96);
            this.gameCellControl9.Name = "gameCellControl9";
            this.gameCellControl9.Size = new System.Drawing.Size(85, 85);
            this.gameCellControl9.TabIndex = 0;
            this.gameCellControl9.Value = "?";
            this.gameCellControl9.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl9.Load += new System.EventHandler(this.gameCellControl7_Load);
            // 
            // gameCellControl10
            // 
            this.gameCellControl10.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl10.GameCellCol = 4;
            this.gameCellControl10.GameCellRow = 1;
            this.gameCellControl10.Location = new System.Drawing.Point(372, 96);
            this.gameCellControl10.Name = "gameCellControl10";
            this.gameCellControl10.Size = new System.Drawing.Size(87, 85);
            this.gameCellControl10.TabIndex = 0;
            this.gameCellControl10.Value = "?";
            this.gameCellControl10.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl10.Load += new System.EventHandler(this.gameCellControl7_Load);
            // 
            // gameCellControl11
            // 
            this.gameCellControl11.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl11.GameCellCol = 0;
            this.gameCellControl11.GameCellRow = 2;
            this.gameCellControl11.Location = new System.Drawing.Point(4, 188);
            this.gameCellControl11.Name = "gameCellControl11";
            this.gameCellControl11.Size = new System.Drawing.Size(85, 85);
            this.gameCellControl11.TabIndex = 0;
            this.gameCellControl11.Value = "?";
            this.gameCellControl11.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl11.Load += new System.EventHandler(this.gameCellControl6_Load);
            // 
            // gameCellControl12
            // 
            this.gameCellControl12.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl12.GameCellCol = 1;
            this.gameCellControl12.GameCellRow = 2;
            this.gameCellControl12.Location = new System.Drawing.Point(96, 188);
            this.gameCellControl12.Name = "gameCellControl12";
            this.gameCellControl12.Size = new System.Drawing.Size(85, 85);
            this.gameCellControl12.TabIndex = 0;
            this.gameCellControl12.Value = "?";
            this.gameCellControl12.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl12.Load += new System.EventHandler(this.gameCellControl6_Load);
            // 
            // gameCellControl13
            // 
            this.gameCellControl13.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl13.GameCellCol = 3;
            this.gameCellControl13.GameCellRow = 2;
            this.gameCellControl13.Location = new System.Drawing.Point(280, 188);
            this.gameCellControl13.Name = "gameCellControl13";
            this.gameCellControl13.Size = new System.Drawing.Size(85, 85);
            this.gameCellControl13.TabIndex = 0;
            this.gameCellControl13.Value = "?";
            this.gameCellControl13.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl13.Load += new System.EventHandler(this.gameCellControl6_Load);
            // 
            // gameCellControl14
            // 
            this.gameCellControl14.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl14.GameCellCol = 4;
            this.gameCellControl14.GameCellRow = 2;
            this.gameCellControl14.Location = new System.Drawing.Point(372, 188);
            this.gameCellControl14.Name = "gameCellControl14";
            this.gameCellControl14.Size = new System.Drawing.Size(87, 85);
            this.gameCellControl14.TabIndex = 0;
            this.gameCellControl14.Value = "?";
            this.gameCellControl14.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl14.Load += new System.EventHandler(this.gameCellControl6_Load);
            // 
            // gameCellControl15
            // 
            this.gameCellControl15.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl15.GameCellCol = 0;
            this.gameCellControl15.GameCellRow = 3;
            this.gameCellControl15.Location = new System.Drawing.Point(4, 280);
            this.gameCellControl15.Name = "gameCellControl15";
            this.gameCellControl15.Size = new System.Drawing.Size(85, 85);
            this.gameCellControl15.TabIndex = 0;
            this.gameCellControl15.Value = "?";
            this.gameCellControl15.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl15.Load += new System.EventHandler(this.gameCellControl6_Load);
            // 
            // gameCellControl16
            // 
            this.gameCellControl16.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl16.GameCellCol = 1;
            this.gameCellControl16.GameCellRow = 3;
            this.gameCellControl16.Location = new System.Drawing.Point(96, 280);
            this.gameCellControl16.Name = "gameCellControl16";
            this.gameCellControl16.Size = new System.Drawing.Size(85, 85);
            this.gameCellControl16.TabIndex = 0;
            this.gameCellControl16.Value = "?";
            this.gameCellControl16.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl16.Load += new System.EventHandler(this.gameCellControl6_Load);
            // 
            // gameCellControl17
            // 
            this.gameCellControl17.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl17.GameCellCol = 2;
            this.gameCellControl17.GameCellRow = 3;
            this.gameCellControl17.Location = new System.Drawing.Point(188, 280);
            this.gameCellControl17.Name = "gameCellControl17";
            this.gameCellControl17.Size = new System.Drawing.Size(85, 85);
            this.gameCellControl17.TabIndex = 0;
            this.gameCellControl17.Value = "?";
            this.gameCellControl17.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl17.Load += new System.EventHandler(this.gameCellControl6_Load);
            // 
            // gameCellControl18
            // 
            this.gameCellControl18.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl18.GameCellCol = 3;
            this.gameCellControl18.GameCellRow = 3;
            this.gameCellControl18.Location = new System.Drawing.Point(280, 280);
            this.gameCellControl18.Name = "gameCellControl18";
            this.gameCellControl18.Size = new System.Drawing.Size(85, 85);
            this.gameCellControl18.TabIndex = 0;
            this.gameCellControl18.Value = "?";
            this.gameCellControl18.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl18.Load += new System.EventHandler(this.gameCellControl6_Load);
            // 
            // gameCellControl19
            // 
            this.gameCellControl19.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl19.GameCellCol = 4;
            this.gameCellControl19.GameCellRow = 3;
            this.gameCellControl19.Location = new System.Drawing.Point(372, 280);
            this.gameCellControl19.Name = "gameCellControl19";
            this.gameCellControl19.Size = new System.Drawing.Size(87, 85);
            this.gameCellControl19.TabIndex = 0;
            this.gameCellControl19.Value = "?";
            this.gameCellControl19.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl19.Load += new System.EventHandler(this.gameCellControl6_Load);
            // 
            // gameCellControl20
            // 
            this.gameCellControl20.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl20.GameCellCol = 0;
            this.gameCellControl20.GameCellRow = 4;
            this.gameCellControl20.Location = new System.Drawing.Point(4, 372);
            this.gameCellControl20.Name = "gameCellControl20";
            this.gameCellControl20.Size = new System.Drawing.Size(85, 87);
            this.gameCellControl20.TabIndex = 0;
            this.gameCellControl20.Value = "?";
            this.gameCellControl20.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl20.Load += new System.EventHandler(this.gameCellControl6_Load);
            // 
            // gameCellControl21
            // 
            this.gameCellControl21.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl21.GameCellCol = 1;
            this.gameCellControl21.GameCellRow = 4;
            this.gameCellControl21.Location = new System.Drawing.Point(96, 372);
            this.gameCellControl21.Name = "gameCellControl21";
            this.gameCellControl21.Size = new System.Drawing.Size(85, 87);
            this.gameCellControl21.TabIndex = 0;
            this.gameCellControl21.Value = "?";
            this.gameCellControl21.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl21.Load += new System.EventHandler(this.gameCellControl6_Load);
            // 
            // gameCellControl22
            // 
            this.gameCellControl22.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl22.GameCellCol = 2;
            this.gameCellControl22.GameCellRow = 4;
            this.gameCellControl22.Location = new System.Drawing.Point(188, 372);
            this.gameCellControl22.Name = "gameCellControl22";
            this.gameCellControl22.Size = new System.Drawing.Size(85, 87);
            this.gameCellControl22.TabIndex = 0;
            this.gameCellControl22.Value = "?";
            this.gameCellControl22.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl22.Load += new System.EventHandler(this.gameCellControl6_Load);
            // 
            // gameCellControl23
            // 
            this.gameCellControl23.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl23.GameCellCol = 3;
            this.gameCellControl23.GameCellRow = 4;
            this.gameCellControl23.Location = new System.Drawing.Point(280, 372);
            this.gameCellControl23.Name = "gameCellControl23";
            this.gameCellControl23.Size = new System.Drawing.Size(85, 87);
            this.gameCellControl23.TabIndex = 0;
            this.gameCellControl23.Value = "?";
            this.gameCellControl23.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl23.Load += new System.EventHandler(this.gameCellControl6_Load);
            // 
            // gameCellControl24
            // 
            this.gameCellControl24.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameCellControl24.GameCellCol = 4;
            this.gameCellControl24.GameCellRow = 4;
            this.gameCellControl24.Location = new System.Drawing.Point(372, 372);
            this.gameCellControl24.Name = "gameCellControl24";
            this.gameCellControl24.Size = new System.Drawing.Size(87, 87);
            this.gameCellControl24.TabIndex = 0;
            this.gameCellControl24.Value = "?";
            this.gameCellControl24.ButtonClick += new GameCellControlNamespace.GameCellControl.EventHandler(this.TicTacToeButtonClicked);
            this.gameCellControl24.Load += new System.EventHandler(this.gameCellControl6_Load);
            // 
            // gameCellControl25
            // 
            this.gameCellControl25.BackColor = System.Drawing.Color.Transparent;
            this.gameCellControl25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameCellControl25.BackgroundImage")));
            this.gameCellControl25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameCellControl25.Enabled = false;
            this.gameCellControl25.GameCellCol = 2;
            this.gameCellControl25.GameCellRow = 2;
            this.gameCellControl25.Location = new System.Drawing.Point(188, 188);
            this.gameCellControl25.Name = "gameCellControl25";
            this.gameCellControl25.Size = new System.Drawing.Size(85, 85);
            this.gameCellControl25.TabIndex = 0;
            this.gameCellControl25.Value = "!";
            this.gameCellControl25.Load += new System.EventHandler(this.gameCellControl6_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnGoComputer);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form 1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoComputer;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private GameCellControlNamespace.GameCellControl gameCellControl1;
        private GameCellControlNamespace.GameCellControl gameCellControl2;
        private GameCellControlNamespace.GameCellControl gameCellControl3;
        private GameCellControlNamespace.GameCellControl gameCellControl4;
        private GameCellControlNamespace.GameCellControl gameCellControl5;
        private GameCellControlNamespace.GameCellControl gameCellControl6;
        private GameCellControlNamespace.GameCellControl gameCellControl7;
        private GameCellControlNamespace.GameCellControl gameCellControl8;
        private GameCellControlNamespace.GameCellControl gameCellControl9;
        private GameCellControlNamespace.GameCellControl gameCellControl10;
        private GameCellControlNamespace.GameCellControl gameCellControl11;
        private GameCellControlNamespace.GameCellControl gameCellControl12;
        private GameCellControlNamespace.GameCellControl gameCellControl13;
        private GameCellControlNamespace.GameCellControl gameCellControl14;
        private GameCellControlNamespace.GameCellControl gameCellControl15;
        private GameCellControlNamespace.GameCellControl gameCellControl16;
        private GameCellControlNamespace.GameCellControl gameCellControl17;
        private GameCellControlNamespace.GameCellControl gameCellControl18;
        private GameCellControlNamespace.GameCellControl gameCellControl19;
        private GameCellControlNamespace.GameCellControl gameCellControl20;
        private GameCellControlNamespace.GameCellControl gameCellControl21;
        private GameCellControlNamespace.GameCellControl gameCellControl22;
        private GameCellControlNamespace.GameCellControl gameCellControl23;
        private GameCellControlNamespace.GameCellControl gameCellControl24;
        private GameCellControlNamespace.GameCellControl gameCellControl25;
    }
}

