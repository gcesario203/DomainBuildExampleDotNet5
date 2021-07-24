using Domain.Enums;

namespace Domain.Entities.ValueObjects
{
    public struct Document
    {
        public string DocumentNumber { get; private set; }
        public EDocumentTypes DocumentType { get; private set; }

        public Document(string pDocumentNumber, EDocumentTypes pDocumentType)
        {
            this.DocumentNumber = pDocumentNumber;
            this.DocumentType = pDocumentType;
        }
    }
}