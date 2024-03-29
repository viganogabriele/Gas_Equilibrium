﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace _30._2___Equilibrio_Gas
{
    internal class Gas
    {
        public List <Particella> particelle = new List<Particella>();
        public Gas(int nParticelle)
        {
            AggiungiParticelle(nParticelle);
        }
        public void AggiungiParticelle(int nParticelle)
        {
            for (int i = 0; i < nParticelle; i++)
            {
                particelle.Add(new Particella());
            }
        }
        public void SimulaEvoluzione(Random random)
        {
            foreach (Particella p in particelle)
            {
                p.Evoluzione(random);
            }
        }
        public void Risultati(ref int contA, ref int contB)
        {
            contA = 0;
            contB = 0; 
            foreach (Particella p in particelle)
            {
                if (p.settore == 'A')
                {
                    contA++;
                }
                else
                {
                    contB++;
                }
            }
        }
    }
}
