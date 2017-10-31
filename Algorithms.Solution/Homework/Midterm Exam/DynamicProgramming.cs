﻿// Author: Viyrex(aka Yuyu)
// Contact: mailto:viyrex.aka.yuyu@gmail.com
// Github: https://github.com/0x0001F36D

namespace Algorithms.Solution.Homework.Midterm_Exam
{
    using System;
    using Utils;

    [Homework(3)]
    public class DynamicProgramming
    {
        #region Private Enums

        private enum Shuttle
        {
            Left,
            Right
        }

        #endregion Private Enums

        #region Public Methods

        [EntryPoint]
        public static void Run()
        {
            var left = new TOQ(new[] { TO.Rice, TO.Wolf, TO.Dog, TO.Chicken });
            var right = new TOQ();
            var ship = new Ship();

            var switcher = default(Shuttle);

            Label_1:
            disp();
            switch (switcher)
            {
                case Shuttle.Left:

                    if (left.IsEmpty && ship.IsEmpty)
                    {
                        break;
                    }

                    ship.Enqueue(left.Dequeue(1));

                    Label_2:
                    if (left.HasProblem)
                    {
                        if (ship.IsFill)
                        {
                            ship.Cross(left);
                        }
                        else
                        {
                            ship.Enqueue(left.Dequeue(1));
                        }
                        goto Label_2;
                    }
                    else
                    {
                        switcher = Shuttle.Right;
                        goto Label_1;
                    }

                case Shuttle.Right:
                    if (left.IsEmpty && !ship.IsEmpty)
                    {
                        right.Enqueue(ship.DequeueAll());
                        break;
                    }

                    right.Enqueue(ship.DequeueAll());

                    Label_3:
                    if (right.HasProblem)
                    {
                        if (ship.IsFill)
                        {
                            ship.Cross(right);
                        }
                        else
                        {
                            ship.Enqueue(right.Dequeue(1));
                        }
                        goto Label_3;
                    }
                    else
                    {
                        switcher = Shuttle.Left;
                        goto Label_1;
                    }
            }
            disp();
            Console.ReadKey();

            void disp()
            {
                //Console.ReadKey();
                Console.WriteLine("status: " + switcher);
                Console.WriteLine(left);
                Console.WriteLine(ship);
                Console.WriteLine(right);
                Console.WriteLine();
            }
        }

        #endregion Public Methods
    }
}