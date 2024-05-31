namespace Courseword_DN
{
    public partial class MainForm : Form
    {
        private Graphics MGraphics;
        private Pen Pen = new(Color.Black);
        private Graph MGraph { get; set; } = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadFileB_Click(object sender, EventArgs e)
        {
            bool confirmation = true;

            if (!MGraph.IsEmpty())
            {
                confirmation = AskGraphRemovalConfirmation();
            }

            bool loadAsAdjMatrix = RepresentationAdjR.Checked;
            bool loadAsIncMatrix = RepresentationIncR.Checked;
            bool loadAsEdgList = RepresentationEdgesR.Checked;

            if (!confirmation) return;
            using OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;
                if (loadAsAdjMatrix)
                {
                    if (!MGraph.ReadAsAdjencyMatrix(filePath))
                    {
                        ThrowErrorMsg("Chosen file is damaged or selected wrong graph representation for this file");
                    }
                }
                else if (loadAsIncMatrix)
                {
                    if (!MGraph.ReadAsIncidenceMatrix(filePath))
                    {
                        ThrowErrorMsg("Chosen file is damaged or selected wrong graph representation for this file");
                    }
                }
                else if (loadAsEdgList)
                {
                    if (!MGraph.ReadAsEdgesList(filePath))
                    {
                        ThrowErrorMsg("Chosen file is damaged or selected wrong graph representation for this file");
                    }
                }
                UpdateUI();
            }
        }

        private void AproxCoverB_Click(object sender, EventArgs e)
        {
            VertexCoverB_Click(MGraph.AproxVertexCover);
        }

        private void GreedyCoverB_Click(object sender, EventArgs e)
        {
            sender.ToString();
            VertexCoverB_Click(MGraph.GreedyVertexCover);
        }

        private void VertexCoverB_Click(Graph.VertexCoverFunction vertexCoverFunc)
        {
            if (MGraph.IsEmpty())
            {
                ThrowErrorMsg("Graph is empty");
                return;
            }
            if (!MGraph.HaveEdges())
            {
                ThrowErrorMsg("Graph have no edges");
                return;
            }
            MGraph.CalcVertexCover(vertexCoverFunc);
            if (MGraph.IsVertexCoverNullOrEmpty())
            {
                ThrowErrorMsg("Error has been ocured");
                return;
            }
            UpdateUI();            
        }

        private void GenerateRandB_Click(object sender, EventArgs e)
        {
            bool confirmation = true;

            if (!MGraph.IsEmpty())
            {
                confirmation = AskGraphRemovalConfirmation();
            }

            if (!confirmation) return;
            int verticesCount = (int)GenVertCountN.Value;
            MGraph.GenerateRandom(verticesCount);
            UpdateUI();
            
        }

        private void SaveAsB_Click(object sender, EventArgs e)
        {
            if (MGraph.IsEmpty())
            {
                ThrowErrorMsg("Graph is empty");
                return;
            }
            bool saveAsAdjMatrix = RepresentationAdjR.Checked;
            bool saveAsIncMatrix = RepresentationIncR.Checked;
            bool saveAsEdgList = RepresentationEdgesR.Checked;

            using SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bool saved;
                Exception? exc = null;
                var filePath = saveFileDialog.FileName;
                if (saveAsAdjMatrix)
                {
                    saved = MGraph.WriteAsAdjencyMatrix(filePath, out var exception);
                    exc = exception;
                }
                else if (saveAsIncMatrix)
                {
                    saved = MGraph.WriteAsIncidenceMatrix(filePath, out var exception);
                    exc = exception;
                }
                else
                {
                    saved = MGraph.WriteAsEdgesList(filePath, out var exception);
                    exc = exception;
                }
                if (saved)
                {
                    MessageBox.Show("Graph was successfully saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string errorMsg = "An error occurred while trying to save" + exc?.Message;
                    ThrowErrorMsg(errorMsg);
                }
            }
        }

        private void VisualizeGraph()
        {
            if (MGraph.IsEmpty()) return;

            const int circleRadius = 20;
            const int edgePenSize = 1, vertexPenSize = 3, vertexCoverPenSize = 5;
            const int fontSize = 16;
            Color mainColor = Color.Black, vertexCoverColor = Color.Red, edgeColor = Color.BlueViolet;
            var center = new PointF(Canvas.Width / 2, Canvas.Height / 2);
            float radius = Math.Min(center.X, center.Y) - 3 * circleRadius;

            Pen.Width = vertexPenSize;
            Pen.Color = mainColor;
            //Draw Vertices
            foreach (var vertex in MGraph.GetVertices())
            {
                var vertexCenter = GetVertexPos(vertex, radius, center);
                RectangleF drawRect = new(vertexCenter.X - circleRadius, vertexCenter.Y - circleRadius, 2 * circleRadius, 2 * circleRadius);
                MGraphics.DrawEllipse(Pen, drawRect);
            }
            //Draw Edges
            Pen.Width = edgePenSize;
            Pen.Color = edgeColor;
            foreach (var vertex in MGraph.GetVertices())
            {
                var vertexPos = GetVertexPos(vertex, radius, center);
                foreach (var neighbor in vertex.Edges)
                {
                    if (vertex == neighbor)
                    {
                        var vertexPosS = GetVertexPos(neighbor, radius - circleRadius, center);
                        vertexPosS.X -= circleRadius;
                        vertexPosS.Y -= circleRadius;
                        MGraphics.DrawEllipse(Pen, new RectangleF(vertexPosS, new SizeF(circleRadius * 2, circleRadius * 2)));
                    }
                    else
                    {
                        MGraphics.DrawLine(Pen, vertexPos, GetVertexPos(neighbor, radius, center));
                    }
                }
            }
            //Draw IDs
            Pen.Color = mainColor;
            for (int i = 0; i < MGraph.Size(); i++)
            {
                var vertex = MGraph.GetVertex(i);
                var drawPos = GetVertexPos(vertex, radius + circleRadius * 2, center);
                drawPos.X -= fontSize / 2;
                drawPos.Y -= fontSize / 2;
                var drawFont = new Font("Arial", fontSize);
                var drawBrush = new SolidBrush(Color.Black);
                MGraphics.DrawString(i.ToString(), drawFont, drawBrush, drawPos);
            }
            //Draw VertexCover
            Pen.Width = vertexCoverPenSize;
            Pen.Color = vertexCoverColor;
            foreach (var coverVertex in MGraph.GetVertexCover())
            {
                var coverVertexCenter = GetVertexPos(coverVertex, radius, center);
                var coverVertexRect = new RectangleF(coverVertexCenter.X - circleRadius, coverVertexCenter.Y - circleRadius, 2 * circleRadius, 2 * circleRadius);
                MGraphics.DrawEllipse(Pen, coverVertexRect);
            }
        }

        private PointF GetVertexPos(Vertex vertex, float radius, PointF center)
        {
            int i = MGraph.IndexOf(vertex);
            double step = 2 * Math.PI / MGraph.Size();
            return new PointF((float)(Math.Cos(step * i) * radius + center.X), (float)(Math.Sin(step * i) * radius + center.Y));
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            MGraphics = Canvas.CreateGraphics();
            VisualizeGraph();
        }

        private void AddVertexB_Click(object sender, EventArgs e)
        {
            MGraph.AddVertex();
            UpdateUI();            
        }

        private void AddEdgeB_Click(object sender, EventArgs e)
        {
            if (MGraph.Size() == 0)
            {
                ThrowErrorMsg("Graph is empty;");
                return;
            }
            if (ChangeEdgeVertexAD.SelectedIndex == -1)
            {
                ThrowErrorMsg("Choose correct first vertex Index to add");
                return;
            }
            if (ChangeEdgeVertexBD.SelectedIndex == -1)
            {
                ThrowErrorMsg("Choose correct second vertex Index to add");
                return;
            }
            int vertexAIdx = (int)ChangeEdgeVertexAD.SelectedItem;
            int vertexBIdx = (int)ChangeEdgeVertexBD.SelectedItem;

            MGraph.AddEdge(vertexAIdx, vertexBIdx);
            UpdateUI();            
        }

        private void UpdateVerticesComboBox()
        {
            var removeVertexPrevSelected = RemoveVertexD.SelectedItem;
            var changeVertexAPrevSelected = ChangeEdgeVertexAD.SelectedItem;
            var changeVertexBPrevSelected = ChangeEdgeVertexBD.SelectedItem;

            RemoveVertexD.Items.Clear();
            ChangeEdgeVertexAD.Items.Clear();
            ChangeEdgeVertexBD.Items.Clear();

            for (int i = 0; i < MGraph.Size(); i++)
            {
                RemoveVertexD.Items.Add(i);
                ChangeEdgeVertexAD.Items.Add(i);
                ChangeEdgeVertexBD.Items.Add(i);
            }

            if (RemoveVertexD.Items.Count == 0)
            {
                RemoveVertexD.SelectedIndex = -1;
            }
            else if (RemoveVertexD.Items.Contains(removeVertexPrevSelected))
            {
                RemoveVertexD.SelectedItem = removeVertexPrevSelected;
            }
            else
            {
                RemoveVertexD.SelectedIndex = 0;
            }

            if (ChangeEdgeVertexAD.Items.Count == 0)
            {
                ChangeEdgeVertexAD.SelectedIndex = -1;
            }
            else if (ChangeEdgeVertexAD.Items.Contains(changeVertexAPrevSelected))
            {
                ChangeEdgeVertexAD.SelectedItem = changeVertexAPrevSelected;
            }
            else
            {
                ChangeEdgeVertexAD.SelectedIndex = 0;
            }

            if (ChangeEdgeVertexBD.Items.Count == 0)
            {
                ChangeEdgeVertexBD.SelectedIndex = -1;
            }
            else if (ChangeEdgeVertexBD.Items.Contains(changeVertexBPrevSelected))
            {
                ChangeEdgeVertexBD.SelectedItem = changeVertexBPrevSelected;
            }
            else
            {
                ChangeEdgeVertexBD.SelectedIndex = 0;
            }
        }

        private void UpdateButtonsAviability()
        {
            bool vertexDependentButtonsAviability = !MGraph.IsEmpty();
            bool edgeDependentButtonsAviability = MGraph.HaveEdges();
            bool coverDependentButtonsAviability = MGraph.HaveCover();
            SaveAsB.Enabled = vertexDependentButtonsAviability;
            RemoveVertexB.Enabled = vertexDependentButtonsAviability;
            AddEdgeB.Enabled = vertexDependentButtonsAviability;
            ClearGraphB.Enabled = vertexDependentButtonsAviability;
            SaveVertexCoverB.Enabled = coverDependentButtonsAviability;
            RemoveEdgeB.Enabled = edgeDependentButtonsAviability;
            GreedyCoverB.Enabled = edgeDependentButtonsAviability;
            AproxCoverB.Enabled = edgeDependentButtonsAviability;
        }

        private void UpdateUI()
        {
            UpdateButtonsAviability();
            UpdateVerticesComboBox();
            Canvas.Refresh();
        }

        private void RemoveVertexB_Click(object sender, EventArgs e)
        {
            if (MGraph.IsEmpty())
            {
                ThrowErrorMsg("Graph is empty");
                return;
            }
            if (RemoveVertexD.SelectedIndex == -1)
            {
                ThrowErrorMsg("Choose correct vertex Index to delete");
                return;
            }
            MGraph.RemoveVertex((int)RemoveVertexD.SelectedItem);
            UpdateUI();            
        }

        private void ThrowErrorMsg(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RemoveEdgeB_Click(object sender, EventArgs e)
        {
            if (!MGraph.HaveEdges())
            {
                ThrowErrorMsg("There are no edges to remove");
                return;
            }
            if (ChangeEdgeVertexAD.SelectedIndex == -1)
            {
                ThrowErrorMsg("Choose correct first vertex Index to remove");
                return;
            }
            if (ChangeEdgeVertexBD.SelectedIndex == -1)
            {
                ThrowErrorMsg("Choose correct second vertex Index to remove");
                return;
            }

            int vertexAIdx = (int)ChangeEdgeVertexAD.SelectedItem;
            int vertexBIdx = (int)ChangeEdgeVertexBD.SelectedItem;

            if (!MGraph.IsAdjacent(vertexAIdx, vertexBIdx))
            {
                ThrowErrorMsg("Edges must be adjacent");
                return;
            }

            MGraph.RemoveEdge(vertexAIdx, vertexBIdx);     
            UpdateUI();
        }

        private void SaveVertexCoverB_Click(object sender, EventArgs e)
        {
            if (MGraph.IsVertexCoverNullOrEmpty())
            {
                ThrowErrorMsg("Vertex cover does not exists now");
                return;
            }
            using SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = saveFileDialog.FileName;
                if (MGraph.WriteVertexCover(filePath, out var exc))
                {
                    MessageBox.Show("Vertex cover was successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string errorMsg = "An error occurred while trying to save" + exc?.Message;
                    ThrowErrorMsg(errorMsg);
                }
            }
        }

        private void ClearGraphB_Click(object sender, EventArgs e)
        {
            if (AskGraphRemovalConfirmation())
            {
                MGraph.Clear();
                UpdateUI();
            }
        }

        private bool AskGraphRemovalConfirmation()
        {
            return MessageBox.Show("Current graph will be removed", "Confirm?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
        }
    }
}
