using OOPProject.Common.Enums;

namespace OOPProject.Common
{
    public static class Constants
    {
        public static Dictionary<Shape, Dictionary<Calculation, List<string>>> Formulas = new()
        {
            {
                Shape.Circle,
                new Dictionary<Calculation, List<string>>()
                {
                    {
                        Calculation.Area,
                        new List<string>()
                        {
                            "Radius"
                        }
                    },
                    {
                        Calculation.Circumference,
                        new List<string>()
                        {
                            "Radius"
                        }
                    },
                }
            },

            {
                Shape.Cone,
                new Dictionary<Calculation, List<string>>()
                {
                    {
                        Calculation.Area,
                        new List<string>()
                        {
                            "Radius",
                            "Height"
                        }
                    },
                    {
                        Calculation.Volume,
                        new List<string>()
                        {
                            "Radius",
                            "Height"
                        }
                    },
                }
            },

            {
                Shape.Cube,
                new Dictionary<Calculation, List<string>>()
                {
                    {
                        Calculation.Area,
                        new List<string>()
                        {
                            "Length"
                        }
                    },
                    {
                        Calculation.Volume,
                        new List<string>()
                        {
                            "Length"
                        }
                    },
                }
            },

            {
                Shape.Cylinder,
                new Dictionary<Calculation, List<string>>()
                {
                    {
                        Calculation.Area,
                        new List<string>()
                        {
                            "Radius",
                            "Height"
                        }
                    },
                    {
                        Calculation.Volume,
                        new List<string>()
                        {
                            "Radius",
                            "Height"
                        }
                    },
                }
            },

            {
                Shape.Parrellogram,
                new Dictionary<Calculation, List<string>>()
                {
                    {
                        Calculation.Area,
                        new List<string>()
                        {
                            "Height",
                            "Width"
                        }
                    },
                    {
                        Calculation.Circumference,
                        new List<string>()
                        {
                            "Length",
                            "Width"
                        }
                    },
                }
            },

            {
                Shape.Pyramid,
                new Dictionary<Calculation, List<string>>()
                {
                    {
                        Calculation.Area,
                        new List<string>()
                        {
                            "Length",
                            "Height"
                        }
                    },
                    {
                        Calculation.Volume,
                        new List<string>()
                        {
                            "Length",
                            "Height"
                        }
                    },
                }
            },

            {
                Shape.Rectangle,
                new Dictionary<Calculation, List<string>>()
                {
                    {
                        Calculation.Area,
                        new List<string>()
                        {
                            "Length",
                            "Width"
                        }
                    },
                    {
                        Calculation.Circumference,
                        new List<string>()
                        {
                            "Length",
                            "Width"
                        }
                    },
                }
            },

            {
                Shape.RectangularPrisim,
                new Dictionary<Calculation, List<string>>()
                {
                    {
                        Calculation.Area,
                        new List<string>()
                        {
                            "Length",
                            "Width",
                            "Height"
                        }
                    },
                    {
                        Calculation.Volume,
                        new List<string>()
                        {
                            "Length",
                            "Width",
                            "Height"
                        }
                    },
                }
            },

            {
                Shape.Rhombus,
                new Dictionary<Calculation, List<string>>()
                {
                    {
                        Calculation.Area,
                        new List<string>()
                        {
                            "Length"
                        }
                    },
                    {
                        Calculation.Circumference,
                        new List<string>()
                        {
                            "Length"
                        }
                    },
                }
            },

            {
                Shape.Sphere,
                new Dictionary<Calculation, List<string>>()
                {
                    {
                        Calculation.Area,
                        new List<string>()
                        {
                            "Radius"
                        }
                    },
                    {
                        Calculation.Volume,
                        new List<string>()
                        {
                            "Radius"
                        }
                    },
                }
            },

            {
                Shape.Square,
                new Dictionary<Calculation, List<string>>()
                {
                    {
                        Calculation.Area,
                        new List<string>()
                        {
                            "Length"
                        }
                    },
                    {
                        Calculation.Circumference,
                        new List<string>()
                        {
                            "Length"
                        }
                    },
                }
            },

            {
                Shape.Triangle,
                new Dictionary<Calculation, List<string>>()
                {
                    {
                        Calculation.Area,
                        new List<string>()
                        {
                            "Width",
                            "Height"
                        }
                    },
                    {
                        Calculation.Circumference,
                        new List<string>()
                        {
                            "Line1",
                            "Line2",
                            "Line3",
                        }
                    },
                }
            },
        };
    }
}

