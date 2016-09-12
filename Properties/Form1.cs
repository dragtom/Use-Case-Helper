using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Case_helper
{
    public partial class frmMain : Form
    {
        //fields
        private List<Element> elementList = new List<Element>();
        bool currentlyDrawing;
        Point drawPositionStart;
        Point drawPositionEnd;
        private Element selectedElement;
        UseCaseProperties useCasePropertiesForm;

        //constructor
        public frmMain()
        {
            InitializeComponent();
            currentlyDrawing = false;
        }
        //methods

        private void addElement()
        {
            //check which element
            if (rbAddActor.Checked)
            {
                Actor addedActor = new Actor(drawPositionStart.X, drawPositionStart.Y, drawPositionEnd.X, drawPositionEnd.Y, tbEditName.Text);
                elementList.Add(addedActor);
                selectedElement = addedActor;
                lbExistingSymbols.Items.Add(addedActor);
                lbExistingSymbols.SelectedItem = addedActor;
                //drawElement(addedActor);
                //draw actor
            }
            else if (rbAddUseCase.Checked)
            {
                //ElementList.Add(new Actor());
                UseCase addedUseCase = new UseCase(drawPositionStart.X, drawPositionStart.Y, drawPositionEnd.X, drawPositionEnd.Y, tbEditName.Text);
                elementList.Add(addedUseCase);
                selectedElement = addedUseCase;
                lbExistingSymbols.Items.Add(addedUseCase);
                lbExistingSymbols.SelectedItem = addedUseCase;
            }
            else
            {
                Line addedLine = new Line(drawPositionStart.X, drawPositionStart.Y, drawPositionEnd.X, drawPositionEnd.Y, tbEditName.Text);
                elementList.Add(addedLine);
                selectedElement = addedLine;
                lbExistingSymbols.Items.Add(addedLine);
                lbExistingSymbols.SelectedItem = addedLine;
            }
            resetPanel();
        }

        private void deleteElement(Element element)
        {
            if (lbExistingSymbols.Items.Contains(element))
            {
                lbExistingSymbols.Items.Remove(element);
            }
            if (elementList.Contains(element))
            {
                elementList.Remove(element);
            }
            resetPanel();
        }

        private void resetPanel()
        {
            pnlDrawSpace.Invalidate();
        }
        public void updateSelectedUseCase(List<string> inputList)
        {
            if (selectedElement.Type == "UseCase")
            {
                /*
                inputlist:
                returnList.Add(name);
                returnList.Add(summary);
                returnList.Add(actors);
                returnList.Add(assumptions);
                returnList.Add(description);
                returnList.Add(exceptions);
                returnList.Add(result);
                 */
                UseCase selectedUseCase = (UseCase)selectedElement;
                selectedUseCase.Name = inputList[0];
                selectedUseCase.Summary = inputList[1];
                selectedUseCase.Actors = inputList[2];
                selectedUseCase.Assumptions = inputList[3];
                selectedUseCase.Description = inputList[4];
                selectedUseCase.Exceptions = inputList[5];
                selectedUseCase.Result = inputList[6];
                resetPanel();
            }
        }

        //windows-methods
        private void gbElements_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlDrawSpace_MouseClick(object sender, MouseEventArgs e)
        {
            //the panel is clicked!
            //get mouse location;
            Point mouseLocation = PointToClient(Cursor.Position);
            if (rbModeAdd.Checked)
            {
                
                //test if we are currently drawing
                if (currentlyDrawing)
                {
                    drawPositionEnd.X = mouseLocation.X - pnlDrawSpace.Location.X;
                    drawPositionEnd.Y = mouseLocation.Y - pnlDrawSpace.Location.Y;
                    addElement();
                    currentlyDrawing = false;
                    //MessageBox.Show("end:" + mouseLocation.X + "," + mouseLocation.Y);
                }
                else
                {
                    drawPositionStart.X = mouseLocation.X - pnlDrawSpace.Location.X;
                    drawPositionStart.Y = mouseLocation.Y - pnlDrawSpace.Location.Y;
                    currentlyDrawing = true;
                    //MessageBox.Show("start:" + mouseLocation.X + "," + mouseLocation.Y);
                }
            }
            else
            {
                int currentLocationX = mouseLocation.X - pnlDrawSpace.Location.X;
                int currentLocationY = mouseLocation.Y - pnlDrawSpace.Location.Y;
                bool foundElement = false;
                foreach (Element element in elementList)
                {
                    if (foundElement)
                    {
                        break;
                    }
                    switch (element.Type)
                    {
                        case "Actor":
                        case "UseCase":
                            //take the X-center of the object and detect wether the abs. difference with the mouseX < imageWidth/2; same for Y
                            int centerX = element.X1 + (element.X2 - element.X1) / 2;
                            int centerY = element.Y1 + (element.Y2 - element.Y1) / 2;
                            if ((Math.Abs(currentLocationX - centerX) <= (element.X2 - element.X1) / 2) && (Math.Abs(currentLocationY - centerY) <= (element.Y2 - element.Y1) / 2))
                            {
                                selectedElement = element;
                                lbExistingSymbols.SelectedItem = element;
                                foundElement = true;
                                //MessageBox.Show(element.ToString());
                            }
                            break;
                        case "Line":
                            //special non-mathematical case if x2 = x1 or y2 = y1; same scenario as in actor/use case
                            if ((element.X2 == element.X1) || (element.Y2 == element.Y1))
                            {
                                int centerLineX = element.X1 + (element.X2 - element.X1) / 2;
                                int centerLineY = element.Y1 + (element.Y2 - element.Y1) / 2;
                                if ((Math.Abs(currentLocationX - centerLineX) <= Math.Abs((10 + element.X2 - element.X1) / 2)) && (Math.Abs(currentLocationY - centerLineY) <= Math.Abs((10 + element.Y2 - element.Y1) / 2)))
                                {
                                    selectedElement = element;
                                    lbExistingSymbols.SelectedItem = element;
                                    foundElement = true;
                                    //MessageBox.Show(element.ToString());
                                }
                            }
                            else
                            {
                                //get formula for line: Y = rc * x + originHeight
                                double rc = (Convert.ToDouble(element.Y2 - element.Y1)) / (Convert.ToDouble(element.X2 - element.X1));
                                //MessageBox.Show(Convert.ToString(rc));
                                //MessageBox.Show(Convert.ToString((element.Y2 - element.Y1) / (element.X2 - element.X1)));
                                double originHeight = (element.Y1 - (rc * element.X1));
                                //distance between point and line is perpendicular to line; perpendicular lines' rc-product = -1;
                                double rcPerp = -1 / rc;
                                double originHeightPerp = (currentLocationY - (rcPerp * currentLocationX));
                                //get the point where the lines intersect
                                //rc*x+oh = rcP*x+ohP --> (rc-rcP)x = ohP-oh --> x = (ohP-oh)/(rc-rcP);
                                double xIntersect = (originHeightPerp - originHeight) / (rc - rcPerp);
                                double yIntersect = rc * xIntersect + originHeight;
                                //the distance between 2 points using pythagorian theorem
                                double distance = Math.Sqrt(Math.Pow(xIntersect - currentLocationX, 2) + Math.Pow(yIntersect - currentLocationY, 2));
                                //MessageBox.Show(Convert.ToString(distance));
                                if (distance <= 5) {
                                    //it's nearby the infinite line, test if it is near the linepart using the same method as actor
                                    int centerLineX = element.X1 + (element.X2 - element.X1) / 2;
                                    int centerLineY = element.Y1 + (element.Y2 - element.Y1) / 2;
                                    if ((Math.Abs(currentLocationX - centerLineX) <= Math.Abs((10 + element.X2 - element.X1) / 2)) && (Math.Abs(currentLocationY - centerLineY) <= Math.Abs((10 + element.Y2 - element.Y1) / 2)))
                                    {
                                        selectedElement = element;
                                        lbExistingSymbols.SelectedItem = element;
                                        foundElement = true;
                                        //MessageBox.Show(element.ToString());
                                    }
                                }
                            }
                            break;
                    }
                }
            }

        }

        private void pnlDrawSpace_Paint(object sender, PaintEventArgs e)
        {
            Font font = DefaultFont;
            foreach (Element element in elementList)
            {
                Pen pen;
                Brush brush;
                PointF location;
                if (element == selectedElement)
                {
                    pen = new Pen(Color.Red);
                    brush = Brushes.Red;
                }
                else
                {
                    pen = new Pen(Color.Black);
                    brush = Brushes.Black;
                }
                
                switch (element.Type)
                {
                    case "Actor":
                        int imageWidth = element.X2 - element.X1;
                        int imageHeight = element.Y2 - element.Y1;
                        e.Graphics.DrawEllipse(pen, element.X1, element.Y1, imageWidth, imageHeight / 3);
                        e.Graphics.DrawLine(pen, element.X1 + imageWidth / 2, element.Y1 + imageHeight / 3, element.X1 + imageWidth / 2, element.Y1 + 2 * imageHeight / 3);
                        e.Graphics.DrawLine(pen, element.X1, element.Y1 + 5 * imageHeight / 8, element.X1 + imageWidth / 2, element.Y1 + imageHeight / 2);
                        e.Graphics.DrawLine(pen, element.X1 + imageWidth , element.Y1 + 5 * imageHeight / 8, element.X1 + imageWidth / 2, element.Y1 + imageHeight / 2);
                        e.Graphics.DrawLine(pen, element.X1, element.Y1 + imageHeight, element.X1 + imageWidth / 2, element.Y1 + 2 * imageHeight / 3);
                        e.Graphics.DrawLine(pen, element.X1 + imageWidth / 2, element.Y1 + 2 * imageHeight / 3, element.X1 + imageWidth, element.Y1 + imageHeight);
                        location = new PointF(element.X1, element.Y2);
                        e.Graphics.DrawString(element.Name, font, brush, location);
                        break;
                    case "UseCase":
                        e.Graphics.DrawEllipse(pen, element.X1, element.Y1, element.X2 - element.X1, element.Y2 - element.Y1);
                        location = new PointF(element.X1 + (element.X2 - element.X1) / 4, element.Y1 + (element.Y2 - element.Y1) / 4);
                        e.Graphics.DrawString(element.Name, font, brush, location);
                        break;
                    case "Line":
                        e.Graphics.DrawLine(pen, element.X1, element.Y1, element.X2, element.Y2);
                        break;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedElement != null)
            {
                deleteElement(selectedElement);
            }
        }

        private void lbExistingSymbols_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbExistingSymbols.SelectedIndex >= 0)
            {
                selectedElement = (Element) lbExistingSymbols.SelectedItem;
                tbEditX1.Text = Convert.ToString(selectedElement.X1);
                tbEditY1.Text = Convert.ToString(selectedElement.Y1);
                tbEditX2.Text = Convert.ToString(selectedElement.X2);
                tbEditY2.Text = Convert.ToString(selectedElement.Y2);
                tbEditName.Text = selectedElement.Name;
                resetPanel();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedElement != null)
            {
                int output;
                int.TryParse(tbEditX1.Text, out output);
                selectedElement.X1 = output;
                int.TryParse(tbEditY1.Text, out output);
                selectedElement.Y1 = output;
                int.TryParse(tbEditX2.Text, out output);
                selectedElement.X2 = output;
                int.TryParse(tbEditY2.Text, out output);
                selectedElement.Y2 = output;
                selectedElement.Name = tbEditName.Text;
                lbExistingSymbols.Items.Clear();
                foreach (Element element in elementList)
                {
                    lbExistingSymbols.Items.Add(element);
                }
                resetPanel();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedElement.Type == "UseCase")
            {
                UseCase selectedUseCase = (UseCase)selectedElement;
                useCasePropertiesForm = new UseCaseProperties(selectedUseCase.getProperties(), this);
                useCasePropertiesForm.Show();
            }
        }
    }
}
