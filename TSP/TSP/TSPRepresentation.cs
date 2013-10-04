using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
namespace TSP {
	public class TSPRepresentation {
		public PointF[] Points;
		public TSPRepresentation(string fileName) {
			ParseFile(fileName);
		}
		void ParseFile(string fileName) {
			string[] text = System.IO.File.ReadAllLines(fileName);
			var entries = text.Where(x => Regex.IsMatch(x, @"[\d\.]+\s[\d\.]")).ToArray();
			Points = new PointF[entries.Length];
			for(int i = 0; i < entries.Length; ++i) {
				string[] split = entries[i].Split(' ');
				if(split.Length != 2) throw new Exception("Unexpected result");
				float t;
				if(!float.TryParse(split[0], out t)) throw new Exception("Unexpected result");
				Points[i].X = t;
				if(!float.TryParse(split[1], out t)) throw new Exception("Unexpected result");
				Points[i].Y = t;
			}
		}
	}
}
