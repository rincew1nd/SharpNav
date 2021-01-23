using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SharpNav.IO.RecastAndDetour
{
    public class NavMeshRndSerializer : NavMeshSerializer
    {
        //increase this once every time the file format changes.
        private static readonly int FormatVersion = 0;

        public NavMeshJsonSerializer()
        {
        }

        public override TiledNavMesh Deserialize(string path)
        {
            throw new NotImplementedException();
        }

        public override void Serialize(string path, TiledNavMesh mesh)
        {
            throw new NotImplementedException();
        }
    }
}
