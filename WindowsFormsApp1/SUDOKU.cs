using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SUDOKU : Form
    {
        public SUDOKU()
        {
            InitializeComponent();
            createCells(9);
            startNewGame();
        }
        private void startNewGame()
        {
            loadValues();
            var hintsCount = 0;

            if (rb_bajo.Checked)
                hintsCount = 45;
            else if (rb_intermedio.Checked)
                hintsCount = 30;
            else if (rb_alto.Checked)
                hintsCount = 15;

            tablero(hintsCount);
        }

        private void loadValues()
        {
            foreach (var cell in cells)
            {
                cell.Value = 0;
                cell.Clear();
            }
            findValueForNextCell(0, -1);
        }

        Random random = new Random();
        private bool findValueForNextCell(int i, int j)
        {            
            if (++j > 8)
            {
                j = 0;                // Exit if the line ends
                if (++i > 8)
                    return true;
            }
            var value = 0;
            var numsLeft = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            do{    
                               
                if (numsLeft.Count < 1)
                {
                    cells[i, j].Value = 0;
                    return false;
                }
                // Toma un número aleatorio de los números que quedan en la lista                
                value = numsLeft[random.Next(0, numsLeft.Count)];
                cells[i, j].Value = value;

                numsLeft.Remove(value);
            }while (!isValidNumber(value, i, j) || !findValueForNextCell(i, j));

            cells[i, j].Text = value.ToString();

            return true;
        }

        private bool isValidNumber(int value, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {// dirección vertical              
                if (i != y && cells[x, i].Value == value)
                    return false;
                // dirección horizontal                 
                if (i != x && cells[i, y].Value == value)
                    return false;
            } // Verifica bloque            
            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && cells[i, j].Value == value)
                        return false;
                }
            }
            return true;
        }
        SudokuCell[,] cells = new SudokuCell[9, 9];

        private void createCells(int tam)
        {
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {  // Create 81 cells for with styles and locations based on the index
                    cells[i, j] = new SudokuCell();
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    cells[i, j].Size = new Size(40, 40);
                    cells[i, j].ForeColor = SystemColors.ControlDarkDark;
                    cells[i, j].Location = new Point(i * 40, j * 40);
                    cells[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.Blue;
                    cells[i, j].X = i;
                    cells[i, j].Y = j;

                    // Assign key press event for each cells
                    cells[i, j].KeyPress += cell_keyPressed;
                    panel1.Controls.Add(cells[i, j]);
                }
            }
        }

        private void cell_keyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as SudokuCell;
            // Do nothing if the cell is locked
            if (cell.IsLocked)
                return;
            int value;
            // Add the pressed key value in the cell only if it is a number
            if (int.TryParse(e.KeyChar.ToString(), out value))
            {    
                if (value == 0)
                    cell.Clear();
                else
                    cell.Text = value.ToString();

                cell.ForeColor = SystemColors.ControlDarkDark;
            }
        }

        private void tablero(int hintsCount)
        {
            for (int i = 0; i < hintsCount; i++)
            {
                var rX = random.Next(9);      var rY = random.Next(9);
                cells[rX, rY].Text = cells[rX, rY].Value.ToString();
                cells[rX, rY].ForeColor = Color.Black;
                cells[rX, rY].IsLocked = true;
            }
        }

        private void btn_verif_Click(object sender, EventArgs e)
        {
            var wrongCells = new List<SudokuCell>();
            // Encuentra todas las entradas incorrectas           
            foreach (var cell in cells)
            {
                if (!string.Equals(cell.Value.ToString(), cell.Text))
                {
                    wrongCells.Add(cell);
                }
            }
            // Comprueba si las entradas son incorrectas o si el jugador gana            
            if (wrongCells.Any())
            { // Resalta las entradas incorrectas                  
                wrongCells.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show("Wrong inputs");
            }
            else
            {
                MessageBox.Show("You Wins");
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            foreach (var cell in cells)
            {// Limpia la celda solo si no está bloqueada                
                if (cell.IsLocked == false)
                    cell.Clear();
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            startNewGame();
        }
    }
}
