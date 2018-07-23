using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Products.Common.Views
{
    public partial class AuswahlDialog : MetroForm
    {
        #region PROPERTIES

        string[] Optionen { get; set; }

        string Titel { get; set; }

        MetroColorStyle ColorStyle { get; set; } = MetroColorStyle.Default;

        #endregion PROPERTIES

        #region public properties

        /// <summary>
        /// Gibt den Index der ausgewählten Option zurück.
        /// </summary>
        public int SelectedOption { get; private set; }

        #endregion public properties

        #region ### .ctor ###

        public AuswahlDialog(string titel, string[] optionen, MetroColorStyle colorStyle = MetroColorStyle.Red)
        {
            InitializeComponent();
            this.Optionen = optionen;
            this.Titel = titel;
            this.ColorStyle = colorStyle;
            this.Style = colorStyle;

            InitializeData();
        }

        #endregion ### .ctor ###

        #region event handler

        void btn_Click(object sender, EventArgs e)
        {
            var button = sender as MetroFramework.Controls.MetroButton;
            this.SelectedOption = (int)(button).Tag;

            //button.DialogResult = DialogResult.OK;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion event handler

        #region private procedures

        void InitializeData()
        {
            var buttonWidth = 120;
            var buttonHeight = 30;
            int buttonCount = Optionen.Length;

            MLblTitel.Text = Titel;
            this.Width = 80 + (buttonCount * buttonWidth) + ((buttonCount - 1) * 20);
            SetPicture();

            for (int i = 0; i < buttonCount; i++)
            {
                var button = new MetroFramework.Controls.MetroButton
                {
                    Text = Optionen[i],
                    Size = new Size(buttonWidth, buttonHeight),
                    Location = new Point(40 + (i * (buttonWidth + 20)), this.Height - 100),
                    Style = this.ColorStyle,
                    Name = $"ButtonOption{i}",
                    TabIndex = i,
                    UseSelectable = true,
                    UseStyleColors = true,
                    Tag = i
                };
                button.Click += btn_Click;
                this.Controls.Add(button);
            }
        }

        void SetPicture()
        {
            switch (this.ColorStyle)
            {
                case MetroColorStyle.Black:
                    this.PicBoxFragezeichen.Image = Properties.Resources.frage_32_metroblue;
                    break;

                case MetroColorStyle.Blue:
                    this.PicBoxFragezeichen.Image = Properties.Resources.frage_32_metroblue;
                    break;

                case MetroColorStyle.Brown:
                    this.PicBoxFragezeichen.Image = Properties.Resources.frage_32_metroblue;
                    break;

                case MetroColorStyle.Default:
                    this.PicBoxFragezeichen.Image = Properties.Resources.frage_32_metroblue;
                    break;

                case MetroColorStyle.Green:
                    this.PicBoxFragezeichen.Image = Properties.Resources.frage_32_metrogreen;
                    break;

                case MetroColorStyle.Lime:
                    this.PicBoxFragezeichen.Image = Properties.Resources.frage_32_metrolime;
                    break;

                case MetroColorStyle.Magenta:
                    this.PicBoxFragezeichen.Image = Properties.Resources.frage_32_metrored;
                    break;

                case MetroColorStyle.Orange:
                    this.PicBoxFragezeichen.Image = Properties.Resources.frage_32_metroorange;
                    break;

                case MetroColorStyle.Pink:
                    this.PicBoxFragezeichen.Image = Properties.Resources.frage_32_metrored;
                    break;

                case MetroColorStyle.Purple:
                    this.PicBoxFragezeichen.Image = Properties.Resources.frage_32_metropink;
                    break;

                case MetroColorStyle.Red:
                    this.PicBoxFragezeichen.Image = Properties.Resources.frage_32_metrored;
                    break;

                case MetroColorStyle.Silver:
                    this.PicBoxFragezeichen.Image = Properties.Resources.frage_32_metroblue;
                    break;

                case MetroColorStyle.Teal:
                    this.PicBoxFragezeichen.Image = Properties.Resources.frage_32_metroblue;
                    break;

                case MetroColorStyle.White:
                    this.PicBoxFragezeichen.Image = Properties.Resources.frage_32_metroblue;
                    break;

                case MetroColorStyle.Yellow:
                    this.PicBoxFragezeichen.Image = Properties.Resources.frage_32_metroyellow;
                    break;

                default:
                    this.PicBoxFragezeichen.Image = Properties.Resources.frage_32_metroblue;
                    break;
            }
        }

        #endregion private procedures
    }
}
