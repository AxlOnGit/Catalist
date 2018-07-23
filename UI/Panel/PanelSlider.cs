using System;
using System.Drawing;
using System.Windows.Forms;
using Transitions;

namespace Products.Common.Panel
{
    public partial class PanelSlider : MetroFramework.Controls.MetroUserControl
    {
        #region PROPERTIES

        ContainerControl ParentCtrl { get; set; }

        bool IsLoaded { get; set; }

        #endregion PROPERTIES

        #region EVENTS

        public event EventHandler OnClosed;

        public event EventHandler OnShown;

        protected virtual void Closed(EventArgs e)
        {
            OnClosed?.Invoke(this, e);
        }

        protected virtual void Shown(EventArgs e)
        {
            OnShown?.Invoke(this, e);
        }

        #endregion EVENTS

        #region PUBLIC PROPERTIES

        /// <summary>
        /// Legt fest, ob das Panel nach dem Ausblenden geladen bleibt.
        /// </summary>
        public bool KeepLoaded { get; private set; }

        #endregion PUBLIC PROPERTIES

        #region ### .ctor ###

        public PanelSlider()
        {
            InitializeComponent();
        }

        public PanelSlider(ContainerControl parent, bool keepLoaded)
        {
            InitializeComponent();
            this.Visible = false;
            this.KeepLoaded = keepLoaded;

            parent.Controls.Add(this);
            this.ParentCtrl = parent;
            this.BringToFront();
            parent.Resize += Owner_Resize;

            ResizeForm();
        }

        #endregion ### .ctor ###

        void PanelSlider_Click(object sender, EventArgs e)
        {
            this.Swipe(false);
        }

        void Owner_Resize(object sender, EventArgs e)
        {
            this.ResizeForm();
        }

        void ResizeForm()
        {
            this.Width = ParentCtrl.Width;
            this.Height = ParentCtrl.Height - 192;
            this.Location = new Point(this.IsLoaded ? 0 : ParentCtrl.Width, 100);
        }

        public void Swipe(bool show = true)
        {
            this.Visible = true;
            var transasition = new Transition(new TransitionType_EaseInEaseOut(5));
            transasition.add(this, "Left", show ? 0 : this.Width);
            transasition.run();

            while (this.Left != (show ? 0 : this.Width))
            {
                Application.DoEvents();
            }

            if (!show)
            {
                this.Closed(new EventArgs());
                this.ParentCtrl.Resize -= Owner_Resize;
                if (!this.KeepLoaded)
                {
                    this.ParentCtrl.Controls.Remove(this);
                    this.Dispose();
                }
            }
            else
            {
                this.IsLoaded = true;
                this.ParentCtrl.Resize += Owner_Resize;
                this.ResizeForm();
                this.Shown(new EventArgs());
            }
        }
    }
}
