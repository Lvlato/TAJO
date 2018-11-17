﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ASD.Graphs;

namespace Tajo
{
	public class Program
	{
		static void Main(string[] args)
		{

            GraphExport ge = new GraphExport();

            Console.WriteLine("TAJO maximal common subgraph project.");
			Console.WriteLine("Press 1 to run exact algorithm.");
			Console.WriteLine("Press 2 to run approximate algorithm no.1");
			Console.WriteLine("Press 3 to run approximate algorithm no.2");

			var x = Console.Read();
            Console.WriteLine("Reading graphs from .csv...");


            var path1 = "..\\..\\Graphs\\graph1.csv";
			var path2 = "..\\..\\Graphs\\graph2.csv";
            var graph1 = GraphReader.ReadCSV(path1);
            var graph2 = GraphReader.ReadCSV(path2);

            CommonGraphSolver gs = new CommonGraphSolver(graph1, graph2);
            

            ge.Export(gs.LineGraph1);
            ge.Export(gs.LineGraph2);
            ge.Export(gs.ModularProductGraph);
			
			switch (x)
			{
				case '1':
					Console.WriteLine("Exact algorithm");
					//
					break;
				case '2':
					Console.WriteLine("Approximate no.1");
					//
					break;
				case '3':
					Console.WriteLine("Approximate no.2");
					//
					break;
				default:
					break;
			}
			 
		}

	}

}