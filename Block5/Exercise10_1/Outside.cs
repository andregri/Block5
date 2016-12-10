using System;

namespace Exercise10_1
{
    class Outside : Location
    {
        private Boolean hot;

        public Outside(string name, Boolean hot) : base(name)
        {
            this.hot = hot;
        }

        public override string Description
        {
            get
            {
                if (hot)
                    return base.Description + "It's very hot here.";

                return base.Description;
            }
        }
    }
}
