using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckList
{
    public class ControlDrag
    {
        /// <summary>
        /// Drags the control within it's client base
        /// </summary>
        /// <param name="client">client where the control is in, like a panel or a form</param>
        /// <param name="control">the control to drag</param>
        /// <param name="enabled">determines whether the dragging is enabled</param>
        /// <param name="cursorEnabled">determines whether the "size all" cursor is enabled</param>
        public ControlDrag(Control client, Control control, Boolean enabled, Boolean cursorEnabled)
        {
            this.Enabled = enabled;
            this.CursorEnabled = cursorEnabled;
            this.client = client;
            this.control = control;
            this.moveControl = control;
            control.MouseDown += new MouseEventHandler(control_MouseDown);
            control.MouseMove += new MouseEventHandler(control_MouseMove);
        }


        public ControlDrag(Control client, Control moveControl, Control control, Boolean enabled, Boolean cursorEnabled)
        {
            this.Enabled = enabled;
            this.CursorEnabled = cursorEnabled;
            this.client = client;
            this.control = control;
            this.moveControl = moveControl;
            control.MouseDown += new MouseEventHandler(control_MouseDown);
            control.MouseMove += new MouseEventHandler(control_MouseMove);
        }

        /// <summary>
        /// Drags the control without a client base, for example a form
        /// </summary>
        /// <param name="control">the control/form to drag</param>
        public ControlDrag(Control control)
            : this(null, control, false, false)
        { }

        // the control which can be dragged but it may be not moved
        Control control;
        Control client;

        // the control which should be moved
        Control moveControl;

        Boolean enabled = false;

        public Boolean Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        Boolean cursorEnabled = false;

        public Boolean CursorEnabled
        {
            get { return cursorEnabled; }
            set { cursorEnabled = value; }
        }

        private System.Drawing.Point mousePosition;

        void control_MouseDown(object sender, MouseEventArgs e)
        {
            if (Enabled)
            {
                this.mousePosition = new Point(-e.X, -e.Y);
            }
        }

        void control_MouseMove(object sender, MouseEventArgs e)
        {
            if (Enabled)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Point mousePos;

                    if (client != null)
                    {
                        mousePos = client.PointToClient(Control.MousePosition);
                    }
                    else
                    {
                        mousePos = Control.MousePosition;
                    }
                    
                    mousePos.Offset(this.mousePosition.X, this.mousePosition.Y);
                    
                    moveControl.Location = mousePos;
                }
                if (CursorEnabled)
                {
                    Cursor.Current = Cursors.SizeAll;
                }
            }
        }
    }
}
