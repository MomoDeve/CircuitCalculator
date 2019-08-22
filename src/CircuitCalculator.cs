using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CircuitCalculator
{
    public partial class CircuitCalculator : Form
    {
        readonly string electronicCircuit = "Electronic Circuit";
        readonly string integratedCircuit = "Integrated Logic Circuit";
        readonly string goodElectronicCircuit = "Good Electronic Circuit";
        readonly string goodIntegratedCircuit = "Good Integrated Circuit";
        readonly string advancedCircuit = "Advanced Circuit";
        readonly string integratedProcessor = "Integrated Processor";
        readonly string processorAssembly = "Processor Assembly";
        readonly string nanoprocessor = "Nanoprocessor";
        readonly string workstation = "Workstation";
        readonly string nanoprocessorAssembly = "Nanoprocessor Assembly";
        readonly string quantumprocessor = "Quantumprocessor";
        readonly string quantumprocessorAssembly = "Quantumprocessor Assembly";
        readonly string eliteNanocomputer = "Elite Nanocomputer";
        readonly string mainframe = "Mainframe";
        readonly string crystalprocessor = "Crystalprocessor";
        readonly string nanoprocessorMainframe = "Nanoprocessor Mainframe";
        readonly string masterQuantumcomputer = "Master Quantumcomputer";
        readonly string wetwareprocessor = "Wetwareprocessor";
        readonly string crystalprocessorAssembly = "Crystalprocessor Assembly";

        List<NumericUpDown> Numerics = new List<NumericUpDown>();

        public CircuitCalculator()
        {
            InitializeComponent();

            #region CIRCUITS
            Circuits.Add(electronicCircuit, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    { "Circuit Board", 1 },
                    { "SMD Resistor", 2 },
                    { "1x Red Alloy Wire", 2 },
                    { "Vaccum Tube", 2 }
                }
            });

            Circuits.Add(integratedCircuit, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    { "Circuit Board", 1 },
                    { "SMD Resistor", 2 },
                    { "SMD Diode", 2 },
                    { "Fine Copper Wire", 2 },
                    { "Tin Bolt", 2 },
                    { "Integrated Logic Circuit (Wafer-made)", 1 }
                }
            });

            Circuits.Add(goodElectronicCircuit, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    { integratedCircuit, 2 },
                    { "Good Circuit Board", 1 },
                    { "SMD Diode", 2 },
                    { "1x Copper Wire", 2 }
                }
             });

            Circuits.Add(goodIntegratedCircuit, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    { integratedCircuit, 2 },
                    { "Good Circuit Board", 1 },
                    { "SMD Resistor", 4 },
                    { "SMD Diode", 4 },
                    { "Fine Gold Wire", 4 },
                    { "Silver Bolt", 4 }
                }
            });

            Circuits.Add(advancedCircuit, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    { goodIntegratedCircuit, 1 },
                    { "Integrated Logic Circuit (Wafer-made)", 2 },
                    { "Random Access Memory Chip", 2 },
                    { "SMD Transistor", 4 },
                    { "Fine Electrum Wire", 8 },
                    { "Annealed Copper Bolt", 8 }
                }
            });

            Circuits.Add(integratedProcessor, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    { "Plastic Circuit Board", 1 },
                    { "Central Processing Unit", 1},
                    { "SMD Resistor", 4 },
                    { "SMD Capacitor", 4 },
                    { "SMD Transistor", 4 },
                    { "Fine Red Alloy Wire", 4 }
                }
            });

            Circuits.Add(processorAssembly, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    { integratedProcessor, 2 },
                    { "Plastic Circuit Board", 1 },
                    { "Small Coil", 4 },
                    { "SMD Capacitor", 8 },
                    { "Random Access Memory Chip", 4 },
                    { "Fine Red Alloy Wire", 4 }
                }
            });

            Circuits.Add(workstation, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    { processorAssembly, 2 },
                    { "Plastic Circuit Board", 1 },
                    { "SMD Diode", 4 },
                    { "Random Access Memory Chip", 4 },
                    { "Fine Electrum Wire", 16 },
                    { "Platinum Bolt", 16 }
                }
            });

            Circuits.Add(mainframe, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    { workstation, 2 },
                    { "Aluminium Frame Box", 2 },
                    { "Small Coil", 12 },
                    { "SMD Capacitor", 16 },
                    { "Random Access Memory Chip", 16 },
                    { "1x Annealed Copper Wire", 16 },
                }
            });

            Circuits.Add(nanoprocessor, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    { "Advanced Circuit Board", 1 },
                    { "ASoC", 1 },
                    { "Fine Electrum Wire", 8 },
                    { "Platinum Bolt", 8 }
                }
            });

            Circuits.Add(nanoprocessorAssembly, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    {nanoprocessor, 2 },
                    { "Advanced Circuit Board", 1 },
                    { "Small Coil", 8 },
                    { "SMD Capacitor", 8 },
                    { "Random Access Memory Chip", 8 },
                    { "Fine Electrum Wire", 16 },
                }
            });

            Circuits.Add(eliteNanocomputer, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    { nanoprocessorAssembly, 2 },
                    { "Advanced Circuit Board", 1 },
                    { "SMD Diode", 8 },
                    { "NOR Memory Chip", 4 },
                    { "Random Access Memory Chip", 16 },
                    { "Fine Electrum Wire", 16 },
                }
            });

            Circuits.Add(quantumprocessor, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    { "More Advanced Circuit Board", 1 },
                    { "ASoC", 1 },
                    { "Fine Electrum Wire", 16 },
                    { "Niobium-Titanum Bolt", 8 }
                }
            });

            Circuits.Add(quantumprocessorAssembly, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    { quantumprocessor, 2 },
                    { "Advanced Circuit Board", 1 },
                    { "Small Coil", 12 },
                    { "SMD Capacitor", 16 },
                    { "Random Access Memory Chip", 4 },
                    { "Fine Platinum Wire", 24 },
                }
            });

            Circuits.Add(crystalprocessor, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    { "Elite Circuit Board", 1 },
                    { "Crystal SoC", 1 },
                    { "Fine Niobium-Titanum Wire", 8 },
                    { "Yttrium Barium Cuprate Bolt", 8 },
                }
            });

            Circuits.Add(nanoprocessorMainframe, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    { eliteNanocomputer, 2 },
                    { "Aluminium Frame Box", 2 },
                    { "Small Coil", 16 },
                    { "SMD Capacitor", 32 },
                    { "Random Access Memory Chip", 16 },
                    { "1x Annealed Copper Wire", 32 }
                }
            });

            Circuits.Add(masterQuantumcomputer, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    { quantumprocessorAssembly, 2 },
                    { "More Advanced Circuit Board", 1 },
                    { "NOR Memory Chip", 4 },
                    { "SMD Diode", 8 },
                    { "Random Access Memory Chip", 16 },
                    { "Fine Platinum Wire", 48 }
                }
            });

            Circuits.Add(wetwareprocessor, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    { quantumprocessorAssembly, 2 },
                    { "Neuro Processing Unit", 1 },
                    { "Crystal Processing Unit", 1 },
                    { "Nanocomponent Central Processing Unit", 1 },
                    { "SMD Capacitor", 32 },
                    { "SMD Transistor", 32 },
                    { "Fine Yttrium Barium Cuprate Wire", 8 }
                }
            });

            Circuits.Add(crystalprocessorAssembly, new Circuit()
            {
                Components = new Dictionary<string, int>()
                {
                    { crystalprocessor, 2 },
                    { "Elite Circuit Board", 1 },
                    { "Crystal Processing Unit", 1 },
                    { "Small Coil", 24 },
                    { "SMD Capacitor", 32 },
                    { "Random Access Memory Chip", 24 },
                    { "Fine Yttrium Barium Cuprate Wire", 16 }
                }
            });
            #endregion

            int tabIndex = 0;
            int yOffset = 0;
            int xOffset = 10;
            int offsetDelta = 25;
            int elementWidth = 250;
            foreach(var pair in Circuits)
            {
                if(yOffset > 450)
                {
                    yOffset = 0;
                    xOffset += elementWidth + 25;
                }
                var label = new Label()
                {
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                    Location = new System.Drawing.Point(xOffset, yOffset),
                    Size = new System.Drawing.Size(elementWidth, offsetDelta),
                    Text = pair.Key,
                    TabIndex = tabIndex++,
                };
                Controls.Add(label);
                yOffset += offsetDelta;
                var numeric = new NumericUpDown()
                {
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                    Location = new System.Drawing.Point(xOffset, yOffset),
                    Size = new System.Drawing.Size(elementWidth, offsetDelta),
                    Name = pair.Key,
                    TabIndex = tabIndex++,
                    Maximum = 65536
                };
                Numerics.Add(numeric);
                numeric.ValueChanged += new System.EventHandler(CalculateAllCircuits);
                Controls.Add(numeric);
                yOffset += offsetDelta;
            }
        }

        Dictionary<string, int> Components = new Dictionary<string, int>();
        Dictionary<string, Circuit> Circuits = new Dictionary<string, Circuit>();

        private void AddToList(Circuit circuit)
        {
            if (circuit.Amount == 0) return;

            foreach (var pair in circuit.Components)
            {
                if(CraftRecursion.Checked && Circuits.ContainsKey(pair.Key))
                {
                    Circuits[pair.Key].Amount += pair.Value * circuit.Amount;
                    AddToList(Circuits[pair.Key]);
                }
                else
                {
                    if (!Components.ContainsKey(pair.Key)) Components.Add(pair.Key, 0);
                    Components[pair.Key] += pair.Value * circuit.Amount;
                }
            }
        }

        private void UpdateComponentsList()
        {
            ComponentsList.Clear();
            foreach (var pair in Components)
            {
                if (pair.Value > 0)
                {
                    if (StackButton.Checked)
                    {
                        int stacks = pair.Value / 64;
                        int mod = pair.Value % 64;
                        if(stacks > 0 && mod > 0)
                        {
                            ComponentsList.Text +=stacks.ToString() + " * 64 + " + mod.ToString() + " " + pair.Key + '\n';
                        }
                        else if (stacks == 0)
                        {
                            ComponentsList.Text += mod.ToString() + " " + pair.Key + '\n';
                        }
                        else
                        {
                            ComponentsList.Text += stacks.ToString() + " * 64 " + pair.Key + '\n';
                        }
                    }
                    else
                    {
                        ComponentsList.Text += pair.Value.ToString() + "x " + pair.Key + '\n';
                    }
                }
            }
        }

        private void CalculateAllCircuits(object sender, EventArgs e)
        {
            Components.Clear();

            foreach(var numeric in Numerics)
            {
                Circuits[numeric.Name].Amount = (int)numeric.Value;
            }

            foreach(var pair in Circuits)
            {
                AddToList(pair.Value);
            }

            UpdateComponentsList();
        }

        private void HighTierCircuits_CheckedChanged(object sender, EventArgs e)
        {
            if(MaxTierCircuits.Checked)
            {
                Circuits[goodElectronicCircuit].Components.Remove(electronicCircuit);
                Circuits[goodElectronicCircuit].Components.Add(integratedCircuit, 2);

                Circuits[nanoprocessor].Components = new Dictionary<string, int>()
                {
                    { "Advanced Circuit Board", 1 },
                    { "ASoC", 1 },
                    { "Fine Electrum Wire", 8 },
                    { "Platinum Bolt", 8 }
                };

                Circuits[quantumprocessor].Components = new Dictionary<string, int>()
                {
                    { "More Advanced Circuit Board", 1 },
                    { "ASoC", 1 },
                    { "Fine Electrum Wire", 16 },
                    { "Niobium-Titanum Bolt", 8 }
                };

                Circuits[crystalprocessor].Components = new Dictionary<string, int>()
                {
                    { "Elite Circuit Board", 1 },
                    { "Crystal SoC", 1 },
                    { "Fine Niobium-Titanum Wire", 8 },
                    { "Yttrium Barium Cuprate Bolt", 8 },
                };
            }
            else
            {
                Circuits[goodElectronicCircuit].Components.Remove(integratedCircuit);
                Circuits[goodElectronicCircuit].Components.Add(electronicCircuit, 2);

                Circuits[nanoprocessor].Components = new Dictionary<string, int>()
                {
                    { "Advanced Circuit Board", 1 },
                    { "Nanocomponent Central Processing Unit", 1 },
                    { "SMD Resistor", 8 },
                    { "SMD Capacitor", 8 },
                    { "SMD Transistor", 8 },
                    { "Fine Electrum Wire", 8 }
                };

                Circuits[quantumprocessor].Components = new Dictionary<string, int>()
                {
                    { "More Advanced Circuit Board", 1 },
                    { "QBit Processing Unit", 1 },
                    { "Nanocomponent Central Processing Unit", 1 },
                    { "SMD Capacitor", 12 },
                    { "SMD Transistor", 12 },
                    { "Fine Platinum Wire", 16 }
                };

                Circuits[crystalprocessor].Components = new Dictionary<string, int>()
                {
                    { "Elite Circuit Board", 1 },
                    { "Crystal Processing Unit", 1 },
                    { "Nanocomponent Central Processing Unit", 2 },
                    { "SMD Capacitor", 24 },
                    { "SMD Transistor", 24 },
                    { "Fine Niobium-Titanum Wire", 8 },
                };
            }
            CalculateAllCircuits(sender, e);
        }

        private void CraftRecursion_CheckedChanged(object sender, EventArgs e)
        {
            CalculateAllCircuits(sender, e);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            foreach(var numeric in Numerics)
            {
                numeric.Value = 0;
            }
            CalculateAllCircuits(sender, e);
        }

        private void StackButton_CheckedChanged(object sender, EventArgs e)
        {
            CalculateAllCircuits(sender, e);
        }
    }
}
