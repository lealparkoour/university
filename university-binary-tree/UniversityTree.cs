using System;
using System.Collections.Generic;
using System.Text;

namespace university_binary_tree
{
    class UniversityTree
    {
        public PositionNode Root;
        
        
        public int count = 0;

        
        public void  CreatePosition(PositionNode parent, 
            Position PositionToCreate,
            string parentPositionName)
        {
            PositionNode newNode = new PositionNode();
            newNode.Position = PositionToCreate;

            if(Root == null )
            {
                Root = newNode;
                return;

            }

            if(parent==null)
            {
                return;
            }

            if(parent.Position.Name == parentPositionName )
            {
                if(parent.Left == null)
                {
                    parent.Left = newNode;
                    return;
                }

                parent.Right = newNode;
                return;
                   
            }
            CreatePosition(parent.Left, PositionToCreate, parentPositionName);
            CreatePosition(parent.Right, PositionToCreate, parentPositionName);
        }

        public void PrintTree(PositionNode from)
        {
            if (from == null)
            {
                return;
            }
            Console.WriteLine($"{from.Position.Name} : ${from.Position.Salary} : {from.Position.Taxes}%");

            PrintTree(from.Left);
            PrintTree(from.Right);
        }

        public float  Addsalaries(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }

            return from.Position.Salary + Addsalaries(from.Left) + Addsalaries(from.Right);

        }
       


       

        public int CountNodes(PositionNode from)
        {
            if (from == null)
            {
                return count;
            }
            count++;
            CountNodes(from.Left);
            CountNodes(from.Right);
            return count;
        }

        public float SalaryAverage()
        {
            return (Addsalaries(Root) / CountNodes(Root));
        }

        public float SalaryPosition(PositionNode from, String Position)
        {
            if (from == null)
            {
                return 0;
            }
            if (from.Position.Name == Position)
            {
                return from.Position.Salary;
            }
            return SalaryPosition(from.Right, Position) + SalaryPosition(from.Left, Position);
        }

        public double TotalTaxes(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            return (from.Position.Salary * from.Position.Taxes) + TotalTaxes(from.Left) + TotalTaxes(from.Right);
        }
    }


    }

