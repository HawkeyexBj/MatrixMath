/*
 * Author: George Lavezzi 
 * File: UxMatrixMath.cs
 *  Modified by Jack Cannell
 */
using System.ComponentModel;
using System.Text;

namespace MatrixMath
{
    /// <summary>
    /// Gui
    /// </summary>
    public partial class UxMatrixMath : Form
    {
        /// <summary>
        /// The matrix which holds the top loaded array
        /// </summary>
        private Matrix? _a;

        /// <summary>
        /// The matrix which holds the bottom loaded array
        /// </summary>
        private Matrix? _b;

        /// <summary>
        /// Constructor for UxMatrixMath
        /// </summary>
        public UxMatrixMath()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays exceptions
        /// </summary>
        /// <param name="ex">A recoverable Exception</param>
        private void DisplayError(Exception ex)
        {
            MessageBox.Show("Exception encountered \n" + ex);
        }

        /// <summary>
        /// Loads the selected array into _a
        /// </summary>
        /// <param name="sender">The object signaling the event.</param>
        /// <param name="e">Information about the event.</param>
        private void ALoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog()) 
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string[] info = File.ReadAllLines(openFileDialog.FileName);
                        _a = new Matrix(Int32.Parse(info[0]), Int32.Parse(info[1]));
                        int counter = 2;
                        string[] data;
                        while (counter < info.Length) 
                        {
                            data = info[counter].Split(',');
                            _a.AddElement(Int32.Parse(data[0]) - 1, Int32.Parse(data[1]), Int32.Parse(data[2]));
                            counter++;
                        }
                        uxALabel.Text = info[0] + " x " + info[1];
                    }
                }
            }
            catch (Exception ex) 
            {
                DisplayError(ex);
            }
            uxAShow.Enabled = true;
            uxATranspose.Enabled = true;
            if (_a != null && _b != null && (_a.Columns == _b.Columns && _a.Rows == _b.Rows))
            {
                uxAdd.Enabled = true;
                uxSubtract.Enabled = true;
            }
            if (_a != null && _b != null && (_a.Columns == _b.Rows))
            {
                uxMultiply.Enabled = true;
            }
        }

        /// <summary>
        /// This loads the b array into _b
        /// </summary>
        /// <param name="sender">The object signaling the event.</param>
        /// <param name="e">Information about the event.</param>
        private void BLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string[] info = File.ReadAllLines(openFileDialog.FileName);
                        _b = new Matrix(Int32.Parse(info[0]), Int32.Parse(info[1]));
                        int counter = 2;
                        string[] data;
                        while (counter < info.Length)
                        {
                            data = info[counter].Split(',');
                            _b.AddElement(Int32.Parse(data[0]) - 1, Int32.Parse(data[1]), Int32.Parse(data[2]));
                            counter++;
                        }
                        uxBLabel.Text = info[0] + " x " + info[1];
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
            uxBShow.Enabled = true;
            if (_a != null && _b != null && (_a.Columns == _b.Columns && _a.Rows == _b.Rows))
            {
                uxAdd.Enabled = true;
                uxSubtract.Enabled = true;
            }
            else
            {
                uxAdd.Enabled = false;
                uxSubtract.Enabled = false;
            }
            if (_a != null && _b != null && (_a.Columns == _b.Rows))
            {
                uxMultiply.Enabled = true;
            }
            else
            {
                uxMultiply.Enabled = false;
            }
        }

        /// <summary>
        /// This adds the two arrays together
        /// </summary>
        /// <param name="sender">The object signaling the event.</param>
        /// <param name="e">Information about the event.</param>
        private void Add_Click(object sender, EventArgs e)
        {
            MatrixMath holder = new MatrixMath();
            Matrix result = holder.Add(_a!, _b!);
            MessageBox.Show(result.ToString(), "A + B");
        }

        /// <summary>
        /// This shows the _a array
        /// </summary>
        /// <param name="sender">The object signaling the event.</param>
        /// <param name="e">Information about the event.</param>
        private void AShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_a!.ToString(), "A: " + _a.Rows + " x " + _a.Columns);
        }

        /// <summary>
        /// This shows the _b array
        /// </summary>
        /// <param name="sender">The object signaling the event.</param>
        /// <param name="e">Information about the event.</param>
        private void BShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_b!.ToString(), "B: " + _b.Rows + " x " + _b.Columns);
        }

        /// <summary>
        /// This subtracts the _b array from the _a array
        /// </summary>
        /// <param name="sender">The object signaling the event.</param>
        /// <param name="e">Information about the event.</param>
        private void Subtract_Click(object sender, EventArgs e)
        {
            MatrixMath holder = new MatrixMath();
            Matrix result = holder.Subtract(_a!, _b!);
            MessageBox.Show(result.ToString());
        }

        /// <summary>
        /// This swaps the _a and _b array
        /// </summary>
        /// <param name="sender">The object signaling the event.</param>
        /// <param name="e">Information about the event.</param>
        private void Swap_Click(object sender, EventArgs e)
        {
            string textFloor = uxBLabel.Text;
            uxBLabel.Text = uxALabel.Text;
            uxALabel.Text = textFloor;
            Matrix floor = _a!;
            _a = _b;
            _b = floor;
            if (_a != null && _b != null && (_a.Columns == _b.Rows))
            {
                uxMultiply.Enabled = true;
            }
            else
            {
                uxMultiply.Enabled = false;
            }
            if (_a != null)
            {
                uxATranspose.Enabled = true;
                uxAShow.Enabled = true;
            }
            else
            {
                uxAShow.Enabled = false;
                uxATranspose.Enabled = false;
            }
            if (_b != null) 
            {
                uxBShow.Enabled = true;
            }
            else
            {
                uxBShow.Enabled = false;
            }
        }

        /// <summary>
        /// This transposes the _a array
        /// </summary>
        /// <param name="sender">The object signaling the event.</param>
        /// <param name="e">Information about the event.</param>
        private void ATranspose_Click(object sender, EventArgs e)
        {
            MatrixMath holder = new MatrixMath();
            _a = holder.Transpose(_a!);
            uxALabel.Text = _a.Rows + " x " + _a.Columns;
            if (_a != null && _b != null && (_a.Columns == _b.Rows))
            {
                uxMultiply.Enabled = true;
            }
            else
            {
                uxMultiply.Enabled = false;
            }
        }

        /// <summary>
        /// This multiplies the _a and _b arrays together
        /// </summary>
        /// <param name="sender">The object signaling the event.</param>
        /// <param name="e">Information about the event.</param>
        private void Multiply_Click(object sender, EventArgs e)
        {
            MatrixMath holder = new MatrixMath();
            Matrix result = holder.Multiply(_a!, _b!);
            MessageBox.Show(result.ToString());
        }
    }
}