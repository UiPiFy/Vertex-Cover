namespace Courseword_DN
{
    internal class Graph
    {
        public delegate void VertexCoverFunction();
        private List<Vertex> Vertices { get; }
        private List<Vertex> VertexCover { get; }
        private Random RandomGenerator { get; }

        public Vertex GetVertex(int vertexIdx) => Vertices[vertexIdx];

        public List<Vertex> GetVertices() => Vertices;

        public int Size() => Vertices.Count;

        public List<Vertex> GetVertexCover() => VertexCover;

        public bool IsVertexCoverNullOrEmpty()
        {
            return VertexCover is null || VertexCover.Count == 0;
        }

        public Graph() 
        {
            Vertices = [];
            VertexCover = [];
            RandomGenerator = new();
        }

        public void AddVertex()
        {
            Vertices.Add(new Vertex());
        }

        public void AddVertices(int verticesCount)
        {
            for (int i = 0; i < verticesCount; i++)
            {
                AddVertex();
            }
        }

        public void AddEdge(int vertexAIdx, int vertexBIdx)
        {
            Vertices[vertexAIdx].AddEdge(Vertices[vertexBIdx]);
        }

        public bool HaveEdges()
        {
            return Vertices.FirstOrDefault(vertex => vertex.HaveEdges()) is not null;
        }

        public bool HaveCover() => VertexCover.Count > 0;

        public bool IsAdjacent(int vertexAIdx, int vertexBIdx)
        {
            return Vertices[vertexAIdx].IsAdjacent(Vertices[vertexBIdx]);
        }

        public bool ReadAsAdjencyMatrix(string path)
        {
            Clear();
            using var reader = new StreamReader(path);
            if (!int.TryParse(reader.ReadLine(), out int verticesNum)) { Clear(); return false; }
            if (verticesNum <= 0) { Clear(); return false; }

            AddVertices(verticesNum);

            var lines = reader.ReadToEnd().Trim().Split('\n');
            if (lines.Length != verticesNum) { Clear(); return false; }

            foreach (var (lineIdx, line) in Enumerate(lines))
            {
                if (string.IsNullOrEmpty(line)) { Clear(); return false; }

                var neighbors = line.Trim().Split(' ');
                if (neighbors.Length != verticesNum) { Clear(); return false; }

                foreach (var (neighborIdx, neighbor) in Enumerate(neighbors))
                {
                    if (string.IsNullOrEmpty(neighbor)) { Clear(); return false; }
                    if (neighbor.Trim() == "1")
                    {
                        Vertices[lineIdx].AddEdge(Vertices[neighborIdx]);
                    }
                }
            }
            return true;
        }

        public bool WriteAsAdjencyMatrix(string path, out Exception? e)
        {
            e = null;
            if (Vertices is null) return false;
            using var writer = new StreamWriter(path);
            try
            {
                writer.WriteLine(Vertices.Count);
                foreach (var (i, vertexA) in Enumerate(Vertices))
                {
                    foreach (var (j, vertexB) in Enumerate(Vertices))
                    {
                        writer.Write($"{(vertexA.IsAdjacent(vertexB) ? 1 : 0)}");
                        if (j < Vertices.Count - 1)
                            writer.Write(" ");
                    }
                    if (i < Vertices.Count - 1)
                        writer.WriteLine();
                }
                return true;
            }
            catch (Exception exception) when (exception is IOException)
            {
                e = exception;
                return false;
            }            
        }

        public bool ReadAsIncidenceMatrix(string path)
        {
            Clear();
            using var reader = new StreamReader(path);

            if (!int.TryParse(reader.ReadLine(), out int verticesNum)) { Clear(); return false; }
            if (verticesNum <= 0) { Clear(); return false; }
            AddVertices(verticesNum);

            var lines = reader.ReadToEnd().Trim().Split('\n');
            if (lines.Length == 0) { Clear(); return false; }

            foreach (var (lineIdx, line) in Enumerate(lines))
            {
                if (string.IsNullOrEmpty(line)) { Clear(); return false; }

                var incidences = line.Trim().Split(' ');
                if (incidences.Length != verticesNum) { Clear(); return false; }

                var vertexAIdx = IndexOfStr(incidences, "1");
                if (vertexAIdx is null) { Clear(); return false; }
                incidences[(int)vertexAIdx] = "0";

                var vertexBIdx = IndexOfStr(incidences, "1");
                if (vertexBIdx is null) { Clear(); return false; }
                incidences[(int)vertexBIdx] = "0";

                if (IndexOfStr(incidences, "1") is not null) { Clear(); return false; }

                Vertices[(int)vertexAIdx].AddEdge(Vertices[(int)vertexBIdx]);
            }
            return true;
        }

        public bool WriteVertexCover(string path, out Exception? e)
        {
            e = null;
            using var writer = new StreamWriter(path);
            try
            {
                GetVertexCover().ForEach(vertex => writer.Write($"{Vertices.IndexOf(vertex)} "));
                return true;
            }
            catch (Exception exception) when (exception is IOException)
            {
                e = exception;
                return false;
            }
        }

        public bool WriteAsIncidenceMatrix(string path, out Exception? e)
        {
            e = null;
            if (Vertices is null) return false;
            RestoreVisits();
            using var writer = new StreamWriter(path);
            try 
            {
                writer.WriteLine(Vertices.Count);
                Vertex? notVisitedA;
                while ((notVisitedA = GetNotVisited()) is not null)
                {
                    var notVisitedB = notVisitedA.GetNotVisited();
                    for(int i = 0; i < Vertices.Count; i++)
                    {
                        if (Vertices.IndexOf(notVisitedA) == i || Vertices.IndexOf(notVisitedB) == i)
                        {
                            writer.Write($"{1} ");
                        }
                        else
                        {
                            writer.Write($"{0} ");
                        }
                    }
                    writer.WriteLine();
                    notVisitedA.AddVisit(notVisitedB);
                }
                return true;
            }
            catch (Exception exception) when (exception is IOException)
            {
                e = exception;
                return false;
            }
        }

        public bool ReadAsEdgesList(string path)
        {
            Clear();
            using var reader = new StreamReader(path);
            if (!int.TryParse(reader.ReadLine(), out int verticesNum)) { Clear(); return false; }
            AddVertices(verticesNum);

            foreach (var line in reader.ReadToEnd().Trim().Split('\n'))
            {
                if (string.IsNullOrEmpty(line)) { Clear(); return false; }

                var edges = line.Trim().Split(' ');
                if (edges.Length != 2) { Clear(); return false; }
                if (!int.TryParse(edges[0], out int vertexAIdx)) { Clear(); return false; }
                if (!int.TryParse(edges[1], out int vertexBIdx)) { Clear(); return false; }
                if (!IsInBounds(vertexAIdx, 0, Vertices.Count - 1) || !IsInBounds(vertexBIdx, 0, Vertices.Count - 1)) { Clear(); return false; }
                Vertices[vertexAIdx].AddEdge(Vertices[vertexBIdx]);
            }
            return true;
        }

        public bool WriteAsEdgesList(string path, out Exception? e)
        {
            e = null;
            if (Vertices is null) return false;
            RestoreVisits();
            using var writer = new StreamWriter(path);
            try
            {
                writer.WriteLine(Vertices.Count);
                Vertex? notVisitedA;
                while ((notVisitedA = GetNotVisited()) is not null)
                {
                    var notVisitedB = notVisitedA.GetNotVisited();
                    writer.WriteLine($"{Vertices.IndexOf(notVisitedA)} {Vertices.IndexOf(notVisitedB)}");
                    notVisitedA.AddVisit(notVisitedB);
                }
                return true;
            }
            catch (Exception exception) when (exception is IOException)
            {
                e = exception;
                return false;
            }
        }

        public int IndexOf(Vertex vertex) => Vertices.IndexOf(vertex);

        private static int? IndexOfStr(string[] strings, string lookingFor)
        {
            if (string.IsNullOrEmpty(lookingFor)) return null;
            foreach (var (strIdx, str) in Enumerate(strings)) 
            {
                if (str == lookingFor)
                {    
                    return strIdx; 
                }            
            }
            return null;
        }

        private static bool IsInBounds(int num, int min, int max)
        {
            return (num >= min && num <= max);
        }

        public bool IsEmpty() => Vertices.Count == 0;

        public void GenerateRandom(int verticesCount, double edgesRatio = 0.2)
        {
            Clear();
            AddVertices(verticesCount);

            for (int i = 0; i < Math.Max(verticesCount * verticesCount * edgesRatio, verticesCount); i++)
            {
                int vertexAIdx = RandomGenerator.Next(Vertices.Count);
                int vertexBIdx = RandomGenerator.Next(Vertices.Count);

                Vertices[vertexAIdx].AddEdge(Vertices[vertexBIdx]);
            }
        }

        private static IEnumerable<(int, T)> Enumerate<T>(List<T> objects)
        {
            int counter = 0;
            foreach (var obj in objects)
            {
                yield return (counter++, obj);
            }
        }

        private static IEnumerable<(int, T)> Enumerate<T>(T[] objects)
        {
            int counter = 0;
            foreach (var obj in objects)
            {
                yield return (counter++, obj);
            }
        }

        public void AproxVertexCover()
        {
            if (Vertices == null) return;

            ClearVertexCover();
            RestoreVisits();

            Vertex? currentA, currentB;
            while ((currentA = GetNotVisited()) is not null)
            {
                currentB = currentA.GetNotVisited();

                VertexCover.Add(currentA);
                currentA.MarkEdgesVisited();

                if (currentB is null) continue;
                VertexCover.Add(currentB);
                currentB.MarkEdgesVisited();
            }
        }

        public void CalcVertexCover(VertexCoverFunction function)
        {
            function();
        }

        public void GreedyVertexCover()
        {
            if (Vertices == null) return;

            ClearVertexCover();
            RestoreVisits();

            Vertex? current;
            while ((current = GetLeastVisited()) is not null)
            {
                VertexCover.Add(current);
                current.MarkEdgesVisited();
            }
        }

        private Vertex? GetNotVisited()
        {
            return Vertices.FirstOrDefault(item => item.GetNotVisited() is not null);
        }

        private Vertex? GetLeastVisited()
        {
            if (Vertices == null) return null;

            int maxIdx = 0;
            int maxVal = 0;

            foreach (var (idx, vertex) in Enumerate(Vertices))
            {
                if (vertex.NotVisitedCount() > maxVal)
                {
                    maxVal = vertex.NotVisitedCount();
                    maxIdx = idx;
                }
            }

            if (maxVal == 0) return null;
            return Vertices[maxIdx];
        }

        private void ClearVertexCover()
        {
            GetVertexCover().Clear();
        }

        private void RestoreVisits()
        {
            Vertices.ForEach(vertex => vertex.MarkEdgesNotVisited());
        }

        public void Clear()
        {
            Vertices.Clear();
            ClearVertexCover();
        }

        public void RemoveEdge(int vertexAIdx, int vertexBIdx)
        {
            ClearVertexCover();
            Vertices[vertexAIdx].RemoveEdge(Vertices[vertexBIdx]);
        }

        public void RemoveVertex(int vertexIdx)
        {
            ClearVertexCover();
            Vertices[vertexIdx].RemoveEdges();
            Vertices.RemoveAt(vertexIdx);
        }
    }
}
