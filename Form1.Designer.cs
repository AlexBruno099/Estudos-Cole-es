namespace Colecoes
{
    partial class Forms1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lista = new System.Windows.Forms.ListBox();
            this.BtnList = new System.Windows.Forms.Button();
            this.btnHashSet = new System.Windows.Forms.Button();
            this.btnDictionary = new System.Windows.Forms.Button();
            this.btnSortedList = new System.Windows.Forms.Button();
            this.btnSortedDictionary = new System.Windows.Forms.Button();
            this.btnSortedSet = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 29;
            this.Lista.Location = new System.Drawing.Point(0, 2);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(731, 555);
            this.Lista.TabIndex = 0;
            this.Lista.UseTabStops = false;
            // 
            // BtnList
            // 
            this.BtnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnList.Location = new System.Drawing.Point(737, 2);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(217, 73);
            this.BtnList.TabIndex = 1;
            this.BtnList.Text = "List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // btnHashSet
            // 
            this.btnHashSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHashSet.Location = new System.Drawing.Point(737, 81);
            this.btnHashSet.Name = "btnHashSet";
            this.btnHashSet.Size = new System.Drawing.Size(217, 73);
            this.btnHashSet.TabIndex = 2;
            this.btnHashSet.Text = "Hash Set";
            this.btnHashSet.UseVisualStyleBackColor = true;
            this.btnHashSet.Click += new System.EventHandler(this.btnHashSet_Click);
            // 
            // btnDictionary
            // 
            this.btnDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDictionary.Location = new System.Drawing.Point(737, 160);
            this.btnDictionary.Name = "btnDictionary";
            this.btnDictionary.Size = new System.Drawing.Size(217, 73);
            this.btnDictionary.TabIndex = 3;
            this.btnDictionary.Text = "Dictionary";
            this.btnDictionary.UseVisualStyleBackColor = true;
            this.btnDictionary.Click += new System.EventHandler(this.btnDictionary_Click);
            // 
            // btnSortedList
            // 
            this.btnSortedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortedList.Location = new System.Drawing.Point(737, 239);
            this.btnSortedList.Name = "btnSortedList";
            this.btnSortedList.Size = new System.Drawing.Size(217, 73);
            this.btnSortedList.TabIndex = 4;
            this.btnSortedList.Text = "SortedList";
            this.btnSortedList.UseVisualStyleBackColor = true;
            this.btnSortedList.Click += new System.EventHandler(this.btnSortedList_Click);
            // 
            // btnSortedDictionary
            // 
            this.btnSortedDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortedDictionary.Location = new System.Drawing.Point(737, 318);
            this.btnSortedDictionary.Name = "btnSortedDictionary";
            this.btnSortedDictionary.Size = new System.Drawing.Size(217, 73);
            this.btnSortedDictionary.TabIndex = 5;
            this.btnSortedDictionary.Text = "SortedDictionary";
            this.btnSortedDictionary.UseVisualStyleBackColor = true;
            this.btnSortedDictionary.Click += new System.EventHandler(this.btnSortedDictionary_Click);
            // 
            // btnSortedSet
            // 
            this.btnSortedSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortedSet.Location = new System.Drawing.Point(737, 397);
            this.btnSortedSet.Name = "btnSortedSet";
            this.btnSortedSet.Size = new System.Drawing.Size(217, 73);
            this.btnSortedSet.TabIndex = 6;
            this.btnSortedSet.Text = "SortedSet";
            this.btnSortedSet.UseVisualStyleBackColor = true;
            this.btnSortedSet.Click += new System.EventHandler(this.btnSortedSet_Click);
            // 
            // btnQueue
            // 
            this.btnQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueue.Location = new System.Drawing.Point(737, 484);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(217, 73);
            this.btnQueue.TabIndex = 7;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnStack
            // 
            this.btnStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStack.Location = new System.Drawing.Point(739, 563);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(217, 73);
            this.btnStack.TabIndex = 8;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // Forms1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 640);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.btnSortedSet);
            this.Controls.Add(this.btnSortedDictionary);
            this.Controls.Add(this.btnSortedList);
            this.Controls.Add(this.btnDictionary);
            this.Controls.Add(this.btnHashSet);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.Lista);
            this.Name = "Forms1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listas Genericas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button btnHashSet;
        private System.Windows.Forms.Button btnDictionary;
        private System.Windows.Forms.Button btnSortedList;
        private System.Windows.Forms.Button btnSortedDictionary;
        private System.Windows.Forms.Button btnSortedSet;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnStack;
    }
}

