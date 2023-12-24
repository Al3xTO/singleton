using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLib
{
    public class SDocRepo
    {
        private List<Document> documents;
        private SDocRepo()
        {
            documents = new List<Document>();
        }

        private static SDocRepo _instance;

        private static readonly object _lock = new object();

        public static SDocRepo GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SDocRepo();
                    }
                }
            }
            return _instance;
        }
        public void AddDocument(Document document)
        {
            documents.Add(document);
        }

        public void RemoveDocument(int Id)
        {
            Document docToDel = documents.Find(doc => doc.DocId == Id);
            if (docToDel != null)
            {
                documents.Remove(docToDel);
            }
            else
            {
                Console.WriteLine("Документ з вказаним ID не знайдено.");
            }
        }
        public Document GetDocumentById(int Id)    
        {
            return documents.Find(doc => doc.DocId == Id);
        }

        public List<Document> GetAllDocuments() {
            return documents;
        }
        public void ClearAll()
        {
            documents.Clear();
        }
    }
}
