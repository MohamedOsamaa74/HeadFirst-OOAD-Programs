using System;
using System.Collections.Generic;
using System.Text;
using Chapter_1.Enums;

namespace Chapter_1
{
    public class GuitarSpec(Builder Builder, string Model, Enums.Type Type, Wood BackWood, Wood TopWood, int NumString)
    {
        #region Properties
        private Builder? Builder { get; set; } = Builder;
        private string? Model { get; set; } = Model;
        private Enums.Type? Type { get; set; } = Type;
        private Wood? BackWood { get; set; } = BackWood;
        private Wood? TopWood { get; set; } = TopWood;
        private int NumString { get; set; } = NumString;
        #endregion

        #region Methods
        public Builder GetBuilder()
        {
            return (Builder)Builder;
        }

        public string GetModel()
        {
            return Model;
        }

        public Enums.Type GetType()
        {
            return (Enums.Type)Type;
        }

        public Wood GetBackWood()
        {
            return (Wood)BackWood;
        }

        public Wood GetTopWood()
        {
            return (Wood)TopWood;
        }

        public int GetNumString()
        {
            return NumString;
        }
        public bool Compare(GuitarSpec spec)
        {
            if ((Builder != spec.Builder) || (Model != spec.Model) || (Type != spec.Type)
            || (BackWood != spec.BackWood) || (TopWood != spec.TopWood) || (NumString != spec.NumString))
                return false;
            return true;
        }
        #endregion
    }
}
