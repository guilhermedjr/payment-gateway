using PaymentContext.Domain.Enums;

namespace PaymentContext.Domain.ValueObjects;

public class Document : ValueObject
{
    public Document(string number, EDocumentType type)
    {
        Number = number;
        Type = type;

        AddNotifications(new Contract<Document>()
            .Requires()
            .IsTrue(Validate(), "Document.Number", "Documento inválido")
        );
    }

    public string Number { get; private set; }
    public EDocumentType Type { get; private set; }

    private bool Validate()
    {
        if (Type == EDocumentType.CPF)
            return Utils.IsValidCpf(Number);
        else if (Type == EDocumentType.CNPJ)
        {
            return Utils.IsValidCnpj(Number);
        }
        return false;
    }
}

