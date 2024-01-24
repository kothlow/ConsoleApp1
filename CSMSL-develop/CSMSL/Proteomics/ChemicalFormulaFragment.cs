﻿// Copyright 2022 Derek J. Bailey
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using CSMSL.Chemistry;

namespace CSMSL.Proteomics
{
    public class ChemicalFormulaFragment : Fragment, IChemicalFormula
    {
        public ChemicalFormula ChemicalFormula { get; private set; }

        public ChemicalFormulaFragment(FragmentTypes type, int number, string chemicalFormula, AminoAcidPolymer parent)
            : this(type, number, new ChemicalFormula(chemicalFormula), parent)
        {
        }

        public ChemicalFormulaFragment(FragmentTypes type, int number, ChemicalFormula formula, AminoAcidPolymer parent)
            : base(type, number, formula.MonoisotopicMass, parent)
        {
            ChemicalFormula = new ChemicalFormula(formula);
        }
    }
}