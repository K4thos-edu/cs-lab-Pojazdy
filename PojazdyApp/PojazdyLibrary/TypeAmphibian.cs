using System;

namespace PojazdyLibrary
{
    public class TypeAmphibian : Vehicle
    {
        public EngineType Engine { get; set; }
        public TypeAmphibian(EngineType engineType)
        {
            Type = "Amphibian";
            Engine = engineType;
        }

    }
}
