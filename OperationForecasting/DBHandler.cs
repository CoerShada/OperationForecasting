using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationForecasting
{
    class DBHandler
    {

        public static readonly DBHandler Instance = new DBHandler();
        private readonly ApplicationContext Context;

        private DBHandler()
        {
            Context = new ApplicationContext();
        }

        public List<Material> GetActualMaterials()
        {
            return Context.Materials.ToList();
        }

        public void AddMaterial(Material material)
        {
            Context.Materials.Add(material);
            Context.SaveChanges();
        }

        public void UpdateMaterial(Material material)
        {
            Material editMaterial = Context.Materials.Find(material.GetId());
            if (editMaterial == null)
            {
                throw new InvalidOperationException($"Could not find material \"{material.GetName()}\" in the table \"Materials\"");
            }

            editMaterial.Name = material.Name;
            editMaterial.K = material.K;
            editMaterial.FSigmaD = material.FSigmaD;
            editMaterial.FSigmaL = material.FSigmaL;
            editMaterial.FA1 = material.FA1;
            editMaterial.FA2 = material.FA2;
            editMaterial.FSDelta = editMaterial.FSDelta;
            Context.SaveChanges();
        }

        public void DeleteMaterial(Material material)
        {
            Context.Materials.Remove(material);
            Context.SaveChanges();
        }

        public List<Log> GetActualLogs()
        {
            return Context.Logs.ToList();
        }

        public void AddLog(Log record)
        {
            Context.Logs.Add(record);
            Context.SaveChanges();
            Console.WriteLine("Saved!");

        }


    }
}
