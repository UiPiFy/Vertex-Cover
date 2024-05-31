namespace Courseword_DN
{
    internal class Vertex
    {
        public HashSet<Vertex> Edges { get; }
        private HashSet<Vertex> NotVisited { get; } 

        public Vertex() 
        {
            Edges = [];
            NotVisited = [];
        }

        public void AddEdge(Vertex vertex)
        {
            Edges.Add(vertex);
            NotVisited.Add(vertex);
            vertex.Edges.Add(this);
            vertex.NotVisited.Add(this);
        }

        public void RemoveEdge(Vertex vertex)
        {
            Edges.Remove(vertex);
            NotVisited.Remove(vertex);
            vertex.Edges.Remove(this);
            vertex.NotVisited.Remove(this);
        }

        public void RemoveEdges()
        {
            foreach (var edge in Edges)
            {
                RemoveEdge(edge);
            }
        }

        public bool HaveEdges() => Edges.Count > 0;

        public Vertex? GetNotVisited() => NotVisited.FirstOrDefault();

        public bool IsAdjacent(Vertex vertex) => Edges.Contains(vertex);

        public int NotVisitedCount() => NotVisited.Count;

        public void AddVisit(Vertex vertex)
        {
            NotVisited.Remove(vertex);
            vertex.NotVisited.Remove(this);
        }

        public void MarkEdgesNotVisited()
        {
            foreach (var edge in Edges)
            {
                NotVisited.Add(edge);
            }
        }

        public void MarkEdgesVisited()
        {
            foreach (var edge in Edges)
            {
                AddVisit(edge);
            }
        }
    }
}
