﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

// OBSERVAÇÃO: o código gerado pode exigir pelo menos .NET Framework 4.5 ou .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
public partial class nfeProc
{

    private nfeProcNFe nFeField;

    private nfeProcProtNFe protNFeField;

    private decimal versaoField;

    /// <remarks/>
    public nfeProcNFe NFe
    {
        get
        {
            return this.nFeField;
        }
        set
        {
            this.nFeField = value;
        }
    }

    /// <remarks/>
    public nfeProcProtNFe protNFe
    {
        get
        {
            return this.protNFeField;
        }
        set
        {
            this.protNFeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal versao
    {
        get
        {
            return this.versaoField;
        }
        set
        {
            this.versaoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFe
{

    private nfeProcNFeInfNFe infNFeField;

    private Signature signatureField;

    /// <remarks/>
    public nfeProcNFeInfNFe infNFe
    {
        get
        {
            return this.infNFeField;
        }
        set
        {
            this.infNFeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public Signature Signature
    {
        get
        {
            return this.signatureField;
        }
        set
        {
            this.signatureField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFe
{

    private nfeProcNFeInfNFeIde ideField;

    private nfeProcNFeInfNFeEmit emitField;

    private nfeProcNFeInfNFeDest destField;

    private nfeProcNFeInfNFeRetirada retiradaField;

    private nfeProcNFeInfNFeDet[] detField;

    private nfeProcNFeInfNFeTotal totalField;

    private nfeProcNFeInfNFeTransp transpField;

    private nfeProcNFeInfNFeCobr cobrField;

    private nfeProcNFeInfNFePag pagField;

    private nfeProcNFeInfNFeInfAdic infAdicField;

    private nfeProcNFeInfNFeInfRespTec infRespTecField;

    private decimal versaoField;

    private string idField;

    /// <remarks/>
    public nfeProcNFeInfNFeIde ide
    {
        get
        {
            return this.ideField;
        }
        set
        {
            this.ideField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeEmit emit
    {
        get
        {
            return this.emitField;
        }
        set
        {
            this.emitField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeDest dest
    {
        get
        {
            return this.destField;
        }
        set
        {
            this.destField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeRetirada retirada
    {
        get
        {
            return this.retiradaField;
        }
        set
        {
            this.retiradaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("det")]
    public nfeProcNFeInfNFeDet[] det
    {
        get
        {
            return this.detField;
        }
        set
        {
            this.detField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeTotal total
    {
        get
        {
            return this.totalField;
        }
        set
        {
            this.totalField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeTransp transp
    {
        get
        {
            return this.transpField;
        }
        set
        {
            this.transpField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeCobr cobr
    {
        get
        {
            return this.cobrField;
        }
        set
        {
            this.cobrField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFePag pag
    {
        get
        {
            return this.pagField;
        }
        set
        {
            this.pagField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeInfAdic infAdic
    {
        get
        {
            return this.infAdicField;
        }
        set
        {
            this.infAdicField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeInfRespTec infRespTec
    {
        get
        {
            return this.infRespTecField;
        }
        set
        {
            this.infRespTecField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal versao
    {
        get
        {
            return this.versaoField;
        }
        set
        {
            this.versaoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeIde
{

    private byte cUFField;

    private uint cNFField;

    private string natOpField;

    private byte modField;

    private byte serieField;

    private ushort nNFField;

    private System.DateTime dhEmiField;

    private System.DateTime dhSaiEntField;

    private byte tpNFField;

    private byte idDestField;

    private uint cMunFGField;

    private byte tpImpField;

    private byte tpEmisField;

    private byte cDVField;

    private byte tpAmbField;

    private byte finNFeField;

    private byte indFinalField;

    private byte indPresField;

    private byte indIntermedField;

    private byte procEmiField;

    private decimal verProcField;

    /// <remarks/>
    public byte cUF
    {
        get
        {
            return this.cUFField;
        }
        set
        {
            this.cUFField = value;
        }
    }

    /// <remarks/>
    public uint cNF
    {
        get
        {
            return this.cNFField;
        }
        set
        {
            this.cNFField = value;
        }
    }

    /// <remarks/>
    public string natOp
    {
        get
        {
            return this.natOpField;
        }
        set
        {
            this.natOpField = value;
        }
    }

    /// <remarks/>
    public byte mod
    {
        get
        {
            return this.modField;
        }
        set
        {
            this.modField = value;
        }
    }

    /// <remarks/>
    public byte serie
    {
        get
        {
            return this.serieField;
        }
        set
        {
            this.serieField = value;
        }
    }

    /// <remarks/>
    public ushort nNF
    {
        get
        {
            return this.nNFField;
        }
        set
        {
            this.nNFField = value;
        }
    }

    /// <remarks/>
    public System.DateTime dhEmi
    {
        get
        {
            return this.dhEmiField;
        }
        set
        {
            this.dhEmiField = value;
        }
    }

    /// <remarks/>
    public System.DateTime dhSaiEnt
    {
        get
        {
            return this.dhSaiEntField;
        }
        set
        {
            this.dhSaiEntField = value;
        }
    }

    /// <remarks/>
    public byte tpNF
    {
        get
        {
            return this.tpNFField;
        }
        set
        {
            this.tpNFField = value;
        }
    }

    /// <remarks/>
    public byte idDest
    {
        get
        {
            return this.idDestField;
        }
        set
        {
            this.idDestField = value;
        }
    }

    /// <remarks/>
    public uint cMunFG
    {
        get
        {
            return this.cMunFGField;
        }
        set
        {
            this.cMunFGField = value;
        }
    }

    /// <remarks/>
    public byte tpImp
    {
        get
        {
            return this.tpImpField;
        }
        set
        {
            this.tpImpField = value;
        }
    }

    /// <remarks/>
    public byte tpEmis
    {
        get
        {
            return this.tpEmisField;
        }
        set
        {
            this.tpEmisField = value;
        }
    }

    /// <remarks/>
    public byte cDV
    {
        get
        {
            return this.cDVField;
        }
        set
        {
            this.cDVField = value;
        }
    }

    /// <remarks/>
    public byte tpAmb
    {
        get
        {
            return this.tpAmbField;
        }
        set
        {
            this.tpAmbField = value;
        }
    }

    /// <remarks/>
    public byte finNFe
    {
        get
        {
            return this.finNFeField;
        }
        set
        {
            this.finNFeField = value;
        }
    }

    /// <remarks/>
    public byte indFinal
    {
        get
        {
            return this.indFinalField;
        }
        set
        {
            this.indFinalField = value;
        }
    }

    /// <remarks/>
    public byte indPres
    {
        get
        {
            return this.indPresField;
        }
        set
        {
            this.indPresField = value;
        }
    }

    /// <remarks/>
    public byte indIntermed
    {
        get
        {
            return this.indIntermedField;
        }
        set
        {
            this.indIntermedField = value;
        }
    }

    /// <remarks/>
    public byte procEmi
    {
        get
        {
            return this.procEmiField;
        }
        set
        {
            this.procEmiField = value;
        }
    }

    /// <remarks/>
    public decimal verProc
    {
        get
        {
            return this.verProcField;
        }
        set
        {
            this.verProcField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeEmit
{

    private ulong cNPJField;

    private string xNomeField;

    private nfeProcNFeInfNFeEmitEnderEmit enderEmitField;

    private ulong ieField;

    private byte cRTField;

    /// <remarks/>
    public ulong CNPJ
    {
        get
        {
            return this.cNPJField;
        }
        set
        {
            this.cNPJField = value;
        }
    }

    /// <remarks/>
    public string xNome
    {
        get
        {
            return this.xNomeField;
        }
        set
        {
            this.xNomeField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeEmitEnderEmit enderEmit
    {
        get
        {
            return this.enderEmitField;
        }
        set
        {
            this.enderEmitField = value;
        }
    }

    /// <remarks/>
    public ulong IE
    {
        get
        {
            return this.ieField;
        }
        set
        {
            this.ieField = value;
        }
    }

    /// <remarks/>
    public byte CRT
    {
        get
        {
            return this.cRTField;
        }
        set
        {
            this.cRTField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeEmitEnderEmit
{

    private string xLgrField;

    private byte nroField;

    private string xBairroField;

    private uint cMunField;

    private string xMunField;

    private string ufField;

    private uint cEPField;

    private ushort cPaisField;

    private string xPaisField;

    private uint foneField;

    /// <remarks/>
    public string xLgr
    {
        get
        {
            return this.xLgrField;
        }
        set
        {
            this.xLgrField = value;
        }
    }

    /// <remarks/>
    public byte nro
    {
        get
        {
            return this.nroField;
        }
        set
        {
            this.nroField = value;
        }
    }

    /// <remarks/>
    public string xBairro
    {
        get
        {
            return this.xBairroField;
        }
        set
        {
            this.xBairroField = value;
        }
    }

    /// <remarks/>
    public uint cMun
    {
        get
        {
            return this.cMunField;
        }
        set
        {
            this.cMunField = value;
        }
    }

    /// <remarks/>
    public string xMun
    {
        get
        {
            return this.xMunField;
        }
        set
        {
            this.xMunField = value;
        }
    }

    /// <remarks/>
    public string UF
    {
        get
        {
            return this.ufField;
        }
        set
        {
            this.ufField = value;
        }
    }

    /// <remarks/>
    public uint CEP
    {
        get
        {
            return this.cEPField;
        }
        set
        {
            this.cEPField = value;
        }
    }

    /// <remarks/>
    public ushort cPais
    {
        get
        {
            return this.cPaisField;
        }
        set
        {
            this.cPaisField = value;
        }
    }

    /// <remarks/>
    public string xPais
    {
        get
        {
            return this.xPaisField;
        }
        set
        {
            this.xPaisField = value;
        }
    }

    /// <remarks/>
    public uint fone
    {
        get
        {
            return this.foneField;
        }
        set
        {
            this.foneField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeDest
{

    private ulong cPFField;

    private string xNomeField;

    private nfeProcNFeInfNFeDestEnderDest enderDestField;

    private byte indIEDestField;

    private string emailField;

    /// <remarks/>
    public ulong CPF
    {
        get
        {
            return this.cPFField;
        }
        set
        {
            this.cPFField = value;
        }
    }

    /// <remarks/>
    public string xNome
    {
        get
        {
            return this.xNomeField;
        }
        set
        {
            this.xNomeField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeDestEnderDest enderDest
    {
        get
        {
            return this.enderDestField;
        }
        set
        {
            this.enderDestField = value;
        }
    }

    /// <remarks/>
    public byte indIEDest
    {
        get
        {
            return this.indIEDestField;
        }
        set
        {
            this.indIEDestField = value;
        }
    }

    /// <remarks/>
    public string email
    {
        get
        {
            return this.emailField;
        }
        set
        {
            this.emailField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeDestEnderDest
{

    private string xLgrField;

    private byte nroField;

    private string xCplField;

    private string xBairroField;

    private uint cMunField;

    private string xMunField;

    private string ufField;

    private uint cEPField;

    private ushort cPaisField;

    private string xPaisField;

    private uint foneField;

    /// <remarks/>
    public string xLgr
    {
        get
        {
            return this.xLgrField;
        }
        set
        {
            this.xLgrField = value;
        }
    }

    /// <remarks/>
    public byte nro
    {
        get
        {
            return this.nroField;
        }
        set
        {
            this.nroField = value;
        }
    }

    /// <remarks/>
    public string xCpl
    {
        get
        {
            return this.xCplField;
        }
        set
        {
            this.xCplField = value;
        }
    }

    /// <remarks/>
    public string xBairro
    {
        get
        {
            return this.xBairroField;
        }
        set
        {
            this.xBairroField = value;
        }
    }

    /// <remarks/>
    public uint cMun
    {
        get
        {
            return this.cMunField;
        }
        set
        {
            this.cMunField = value;
        }
    }

    /// <remarks/>
    public string xMun
    {
        get
        {
            return this.xMunField;
        }
        set
        {
            this.xMunField = value;
        }
    }

    /// <remarks/>
    public string UF
    {
        get
        {
            return this.ufField;
        }
        set
        {
            this.ufField = value;
        }
    }

    /// <remarks/>
    public uint CEP
    {
        get
        {
            return this.cEPField;
        }
        set
        {
            this.cEPField = value;
        }
    }

    /// <remarks/>
    public ushort cPais
    {
        get
        {
            return this.cPaisField;
        }
        set
        {
            this.cPaisField = value;
        }
    }

    /// <remarks/>
    public string xPais
    {
        get
        {
            return this.xPaisField;
        }
        set
        {
            this.xPaisField = value;
        }
    }

    /// <remarks/>
    public uint fone
    {
        get
        {
            return this.foneField;
        }
        set
        {
            this.foneField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeRetirada
{

    private ulong cNPJField;

    private string xNomeField;

    private string xLgrField;

    private byte nroField;

    private string xBairroField;

    private uint cMunField;

    private string xMunField;

    private string ufField;

    private uint cEPField;

    private ushort cPaisField;

    private string xPaisField;

    private uint foneField;

    private ulong ieField;

    /// <remarks/>
    public ulong CNPJ
    {
        get
        {
            return this.cNPJField;
        }
        set
        {
            this.cNPJField = value;
        }
    }

    /// <remarks/>
    public string xNome
    {
        get
        {
            return this.xNomeField;
        }
        set
        {
            this.xNomeField = value;
        }
    }

    /// <remarks/>
    public string xLgr
    {
        get
        {
            return this.xLgrField;
        }
        set
        {
            this.xLgrField = value;
        }
    }

    /// <remarks/>
    public byte nro
    {
        get
        {
            return this.nroField;
        }
        set
        {
            this.nroField = value;
        }
    }

    /// <remarks/>
    public string xBairro
    {
        get
        {
            return this.xBairroField;
        }
        set
        {
            this.xBairroField = value;
        }
    }

    /// <remarks/>
    public uint cMun
    {
        get
        {
            return this.cMunField;
        }
        set
        {
            this.cMunField = value;
        }
    }

    /// <remarks/>
    public string xMun
    {
        get
        {
            return this.xMunField;
        }
        set
        {
            this.xMunField = value;
        }
    }

    /// <remarks/>
    public string UF
    {
        get
        {
            return this.ufField;
        }
        set
        {
            this.ufField = value;
        }
    }

    /// <remarks/>
    public uint CEP
    {
        get
        {
            return this.cEPField;
        }
        set
        {
            this.cEPField = value;
        }
    }

    /// <remarks/>
    public ushort cPais
    {
        get
        {
            return this.cPaisField;
        }
        set
        {
            this.cPaisField = value;
        }
    }

    /// <remarks/>
    public string xPais
    {
        get
        {
            return this.xPaisField;
        }
        set
        {
            this.xPaisField = value;
        }
    }

    /// <remarks/>
    public uint fone
    {
        get
        {
            return this.foneField;
        }
        set
        {
            this.foneField = value;
        }
    }

    /// <remarks/>
    public ulong IE
    {
        get
        {
            return this.ieField;
        }
        set
        {
            this.ieField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeDet
{

    private nfeProcNFeInfNFeDetProd prodField;

    private nfeProcNFeInfNFeDetImposto impostoField;

    private byte nItemField;

    /// <remarks/>
    public nfeProcNFeInfNFeDetProd prod
    {
        get
        {
            return this.prodField;
        }
        set
        {
            this.prodField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeDetImposto imposto
    {
        get
        {
            return this.impostoField;
        }
        set
        {
            this.impostoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte nItem
    {
        get
        {
            return this.nItemField;
        }
        set
        {
            this.nItemField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeDetProd
{

    private uint cProdField;

    private ulong cEANField;

    private string xProdField;

    private uint nCMField;

    private uint cESTField;

    private ushort cFOPField;

    private string uComField;

    private decimal qComField;

    private decimal vUnComField;

    private decimal vProdField;

    private ulong cEANTribField;

    private string uTribField;

    private decimal qTribField;

    private decimal vUnTribField;

    private decimal vDescField;

    private byte indTotField;

    private uint xPedField;

    private byte nItemPedField;

    /// <remarks/>
    public uint cProd
    {
        get
        {
            return this.cProdField;
        }
        set
        {
            this.cProdField = value;
        }
    }

    /// <remarks/>
    public ulong cEAN
    {
        get
        {
            return this.cEANField;
        }
        set
        {
            this.cEANField = value;
        }
    }

    /// <remarks/>
    public string xProd
    {
        get
        {
            return this.xProdField;
        }
        set
        {
            this.xProdField = value;
        }
    }

    /// <remarks/>
    public uint NCM
    {
        get
        {
            return this.nCMField;
        }
        set
        {
            this.nCMField = value;
        }
    }

    /// <remarks/>
    public uint CEST
    {
        get
        {
            return this.cESTField;
        }
        set
        {
            this.cESTField = value;
        }
    }

    /// <remarks/>
    public ushort CFOP
    {
        get
        {
            return this.cFOPField;
        }
        set
        {
            this.cFOPField = value;
        }
    }

    /// <remarks/>
    public string uCom
    {
        get
        {
            return this.uComField;
        }
        set
        {
            this.uComField = value;
        }
    }

    /// <remarks/>
    public decimal qCom
    {
        get
        {
            return this.qComField;
        }
        set
        {
            this.qComField = value;
        }
    }

    /// <remarks/>
    public decimal vUnCom
    {
        get
        {
            return this.vUnComField;
        }
        set
        {
            this.vUnComField = value;
        }
    }

    /// <remarks/>
    public decimal vProd
    {
        get
        {
            return this.vProdField;
        }
        set
        {
            this.vProdField = value;
        }
    }

    /// <remarks/>
    public ulong cEANTrib
    {
        get
        {
            return this.cEANTribField;
        }
        set
        {
            this.cEANTribField = value;
        }
    }

    /// <remarks/>
    public string uTrib
    {
        get
        {
            return this.uTribField;
        }
        set
        {
            this.uTribField = value;
        }
    }

    /// <remarks/>
    public decimal qTrib
    {
        get
        {
            return this.qTribField;
        }
        set
        {
            this.qTribField = value;
        }
    }

    /// <remarks/>
    public decimal vUnTrib
    {
        get
        {
            return this.vUnTribField;
        }
        set
        {
            this.vUnTribField = value;
        }
    }

    /// <remarks/>
    public decimal vDesc
    {
        get
        {
            return this.vDescField;
        }
        set
        {
            this.vDescField = value;
        }
    }

    /// <remarks/>
    public byte indTot
    {
        get
        {
            return this.indTotField;
        }
        set
        {
            this.indTotField = value;
        }
    }

    /// <remarks/>
    public uint xPed
    {
        get
        {
            return this.xPedField;
        }
        set
        {
            this.xPedField = value;
        }
    }

    /// <remarks/>
    public byte nItemPed
    {
        get
        {
            return this.nItemPedField;
        }
        set
        {
            this.nItemPedField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeDetImposto
{

    private nfeProcNFeInfNFeDetImpostoICMS iCMSField;

    private nfeProcNFeInfNFeDetImpostoIPI iPIField;

    private nfeProcNFeInfNFeDetImpostoPIS pISField;

    private nfeProcNFeInfNFeDetImpostoCOFINS cOFINSField;

    /// <remarks/>
    public nfeProcNFeInfNFeDetImpostoICMS ICMS
    {
        get
        {
            return this.iCMSField;
        }
        set
        {
            this.iCMSField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeDetImpostoIPI IPI
    {
        get
        {
            return this.iPIField;
        }
        set
        {
            this.iPIField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeDetImpostoPIS PIS
    {
        get
        {
            return this.pISField;
        }
        set
        {
            this.pISField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeDetImpostoCOFINS COFINS
    {
        get
        {
            return this.cOFINSField;
        }
        set
        {
            this.cOFINSField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeDetImpostoICMS
{

    private nfeProcNFeInfNFeDetImpostoICMSICMS60 iCMS60Field;

    private nfeProcNFeInfNFeDetImpostoICMSICMS00 iCMS00Field;

    /// <remarks/>
    public nfeProcNFeInfNFeDetImpostoICMSICMS60 ICMS60
    {
        get
        {
            return this.iCMS60Field;
        }
        set
        {
            this.iCMS60Field = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeDetImpostoICMSICMS00 ICMS00
    {
        get
        {
            return this.iCMS00Field;
        }
        set
        {
            this.iCMS00Field = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeDetImpostoICMSICMS60
{

    private byte origField;

    private byte cSTField;

    private decimal vBCSTRetField;

    private decimal pSTField;

    private decimal vICMSSubstitutoField;

    private decimal vICMSSTRetField;

    private decimal vBCFCPSTRetField;

    private bool vBCFCPSTRetFieldSpecified;

    private decimal pFCPSTRetField;

    private bool pFCPSTRetFieldSpecified;

    private decimal vFCPSTRetField;

    private bool vFCPSTRetFieldSpecified;

    private decimal pRedBCEfetField;

    private decimal vBCEfetField;

    private decimal pICMSEfetField;

    private decimal vICMSEfetField;

    /// <remarks/>
    public byte orig
    {
        get
        {
            return this.origField;
        }
        set
        {
            this.origField = value;
        }
    }

    /// <remarks/>
    public byte CST
    {
        get
        {
            return this.cSTField;
        }
        set
        {
            this.cSTField = value;
        }
    }

    /// <remarks/>
    public decimal vBCSTRet
    {
        get
        {
            return this.vBCSTRetField;
        }
        set
        {
            this.vBCSTRetField = value;
        }
    }

    /// <remarks/>
    public decimal pST
    {
        get
        {
            return this.pSTField;
        }
        set
        {
            this.pSTField = value;
        }
    }

    /// <remarks/>
    public decimal vICMSSubstituto
    {
        get
        {
            return this.vICMSSubstitutoField;
        }
        set
        {
            this.vICMSSubstitutoField = value;
        }
    }

    /// <remarks/>
    public decimal vICMSSTRet
    {
        get
        {
            return this.vICMSSTRetField;
        }
        set
        {
            this.vICMSSTRetField = value;
        }
    }

    /// <remarks/>
    public decimal vBCFCPSTRet
    {
        get
        {
            return this.vBCFCPSTRetField;
        }
        set
        {
            this.vBCFCPSTRetField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool vBCFCPSTRetSpecified
    {
        get
        {
            return this.vBCFCPSTRetFieldSpecified;
        }
        set
        {
            this.vBCFCPSTRetFieldSpecified = value;
        }
    }

    /// <remarks/>
    public decimal pFCPSTRet
    {
        get
        {
            return this.pFCPSTRetField;
        }
        set
        {
            this.pFCPSTRetField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool pFCPSTRetSpecified
    {
        get
        {
            return this.pFCPSTRetFieldSpecified;
        }
        set
        {
            this.pFCPSTRetFieldSpecified = value;
        }
    }

    /// <remarks/>
    public decimal vFCPSTRet
    {
        get
        {
            return this.vFCPSTRetField;
        }
        set
        {
            this.vFCPSTRetField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool vFCPSTRetSpecified
    {
        get
        {
            return this.vFCPSTRetFieldSpecified;
        }
        set
        {
            this.vFCPSTRetFieldSpecified = value;
        }
    }

    /// <remarks/>
    public decimal pRedBCEfet
    {
        get
        {
            return this.pRedBCEfetField;
        }
        set
        {
            this.pRedBCEfetField = value;
        }
    }

    /// <remarks/>
    public decimal vBCEfet
    {
        get
        {
            return this.vBCEfetField;
        }
        set
        {
            this.vBCEfetField = value;
        }
    }

    /// <remarks/>
    public decimal pICMSEfet
    {
        get
        {
            return this.pICMSEfetField;
        }
        set
        {
            this.pICMSEfetField = value;
        }
    }

    /// <remarks/>
    public decimal vICMSEfet
    {
        get
        {
            return this.vICMSEfetField;
        }
        set
        {
            this.vICMSEfetField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeDetImpostoICMSICMS00
{

    private byte origField;

    private byte cSTField;

    private byte modBCField;

    private decimal vBCField;

    private decimal pICMSField;

    private decimal vICMSField;

    /// <remarks/>
    public byte orig
    {
        get
        {
            return this.origField;
        }
        set
        {
            this.origField = value;
        }
    }

    /// <remarks/>
    public byte CST
    {
        get
        {
            return this.cSTField;
        }
        set
        {
            this.cSTField = value;
        }
    }

    /// <remarks/>
    public byte modBC
    {
        get
        {
            return this.modBCField;
        }
        set
        {
            this.modBCField = value;
        }
    }

    /// <remarks/>
    public decimal vBC
    {
        get
        {
            return this.vBCField;
        }
        set
        {
            this.vBCField = value;
        }
    }

    /// <remarks/>
    public decimal pICMS
    {
        get
        {
            return this.pICMSField;
        }
        set
        {
            this.pICMSField = value;
        }
    }

    /// <remarks/>
    public decimal vICMS
    {
        get
        {
            return this.vICMSField;
        }
        set
        {
            this.vICMSField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeDetImpostoIPI
{

    private ushort cEnqField;

    private nfeProcNFeInfNFeDetImpostoIPIIPINT iPINTField;

    /// <remarks/>
    public ushort cEnq
    {
        get
        {
            return this.cEnqField;
        }
        set
        {
            this.cEnqField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeDetImpostoIPIIPINT IPINT
    {
        get
        {
            return this.iPINTField;
        }
        set
        {
            this.iPINTField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeDetImpostoIPIIPINT
{

    private byte cSTField;

    /// <remarks/>
    public byte CST
    {
        get
        {
            return this.cSTField;
        }
        set
        {
            this.cSTField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeDetImpostoPIS
{

    private nfeProcNFeInfNFeDetImpostoPISPISNT pISNTField;

    private nfeProcNFeInfNFeDetImpostoPISPISAliq pISAliqField;

    /// <remarks/>
    public nfeProcNFeInfNFeDetImpostoPISPISNT PISNT
    {
        get
        {
            return this.pISNTField;
        }
        set
        {
            this.pISNTField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeDetImpostoPISPISAliq PISAliq
    {
        get
        {
            return this.pISAliqField;
        }
        set
        {
            this.pISAliqField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeDetImpostoPISPISNT
{

    private byte cSTField;

    /// <remarks/>
    public byte CST
    {
        get
        {
            return this.cSTField;
        }
        set
        {
            this.cSTField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeDetImpostoPISPISAliq
{

    private byte cSTField;

    private decimal vBCField;

    private decimal pPISField;

    private decimal vPISField;

    /// <remarks/>
    public byte CST
    {
        get
        {
            return this.cSTField;
        }
        set
        {
            this.cSTField = value;
        }
    }

    /// <remarks/>
    public decimal vBC
    {
        get
        {
            return this.vBCField;
        }
        set
        {
            this.vBCField = value;
        }
    }

    /// <remarks/>
    public decimal pPIS
    {
        get
        {
            return this.pPISField;
        }
        set
        {
            this.pPISField = value;
        }
    }

    /// <remarks/>
    public decimal vPIS
    {
        get
        {
            return this.vPISField;
        }
        set
        {
            this.vPISField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeDetImpostoCOFINS
{

    private nfeProcNFeInfNFeDetImpostoCOFINSCOFINSNT cOFINSNTField;

    private nfeProcNFeInfNFeDetImpostoCOFINSCOFINSAliq cOFINSAliqField;

    /// <remarks/>
    public nfeProcNFeInfNFeDetImpostoCOFINSCOFINSNT COFINSNT
    {
        get
        {
            return this.cOFINSNTField;
        }
        set
        {
            this.cOFINSNTField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeDetImpostoCOFINSCOFINSAliq COFINSAliq
    {
        get
        {
            return this.cOFINSAliqField;
        }
        set
        {
            this.cOFINSAliqField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeDetImpostoCOFINSCOFINSNT
{

    private byte cSTField;

    /// <remarks/>
    public byte CST
    {
        get
        {
            return this.cSTField;
        }
        set
        {
            this.cSTField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeDetImpostoCOFINSCOFINSAliq
{

    private byte cSTField;

    private decimal vBCField;

    private decimal pCOFINSField;

    private decimal vCOFINSField;

    /// <remarks/>
    public byte CST
    {
        get
        {
            return this.cSTField;
        }
        set
        {
            this.cSTField = value;
        }
    }

    /// <remarks/>
    public decimal vBC
    {
        get
        {
            return this.vBCField;
        }
        set
        {
            this.vBCField = value;
        }
    }

    /// <remarks/>
    public decimal pCOFINS
    {
        get
        {
            return this.pCOFINSField;
        }
        set
        {
            this.pCOFINSField = value;
        }
    }

    /// <remarks/>
    public decimal vCOFINS
    {
        get
        {
            return this.vCOFINSField;
        }
        set
        {
            this.vCOFINSField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeTotal
{

    private nfeProcNFeInfNFeTotalICMSTot iCMSTotField;

    /// <remarks/>
    public nfeProcNFeInfNFeTotalICMSTot ICMSTot
    {
        get
        {
            return this.iCMSTotField;
        }
        set
        {
            this.iCMSTotField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeTotalICMSTot
{

    private decimal vBCField;

    private decimal vICMSField;

    private decimal vICMSDesonField;

    private decimal vFCPField;

    private decimal vBCSTField;

    private decimal vSTField;

    private decimal vFCPSTField;

    private decimal vFCPSTRetField;

    private decimal vProdField;

    private decimal vFreteField;

    private decimal vSegField;

    private decimal vDescField;

    private decimal vIIField;

    private decimal vIPIField;

    private decimal vIPIDevolField;

    private decimal vPISField;

    private decimal vCOFINSField;

    private decimal vOutroField;

    private decimal vNFField;

    /// <remarks/>
    public decimal vBC
    {
        get
        {
            return this.vBCField;
        }
        set
        {
            this.vBCField = value;
        }
    }

    /// <remarks/>
    public decimal vICMS
    {
        get
        {
            return this.vICMSField;
        }
        set
        {
            this.vICMSField = value;
        }
    }

    /// <remarks/>
    public decimal vICMSDeson
    {
        get
        {
            return this.vICMSDesonField;
        }
        set
        {
            this.vICMSDesonField = value;
        }
    }

    /// <remarks/>
    public decimal vFCP
    {
        get
        {
            return this.vFCPField;
        }
        set
        {
            this.vFCPField = value;
        }
    }

    /// <remarks/>
    public decimal vBCST
    {
        get
        {
            return this.vBCSTField;
        }
        set
        {
            this.vBCSTField = value;
        }
    }

    /// <remarks/>
    public decimal vST
    {
        get
        {
            return this.vSTField;
        }
        set
        {
            this.vSTField = value;
        }
    }

    /// <remarks/>
    public decimal vFCPST
    {
        get
        {
            return this.vFCPSTField;
        }
        set
        {
            this.vFCPSTField = value;
        }
    }

    /// <remarks/>
    public decimal vFCPSTRet
    {
        get
        {
            return this.vFCPSTRetField;
        }
        set
        {
            this.vFCPSTRetField = value;
        }
    }

    /// <remarks/>
    public decimal vProd
    {
        get
        {
            return this.vProdField;
        }
        set
        {
            this.vProdField = value;
        }
    }

    /// <remarks/>
    public decimal vFrete
    {
        get
        {
            return this.vFreteField;
        }
        set
        {
            this.vFreteField = value;
        }
    }

    /// <remarks/>
    public decimal vSeg
    {
        get
        {
            return this.vSegField;
        }
        set
        {
            this.vSegField = value;
        }
    }

    /// <remarks/>
    public decimal vDesc
    {
        get
        {
            return this.vDescField;
        }
        set
        {
            this.vDescField = value;
        }
    }

    /// <remarks/>
    public decimal vII
    {
        get
        {
            return this.vIIField;
        }
        set
        {
            this.vIIField = value;
        }
    }

    /// <remarks/>
    public decimal vIPI
    {
        get
        {
            return this.vIPIField;
        }
        set
        {
            this.vIPIField = value;
        }
    }

    /// <remarks/>
    public decimal vIPIDevol
    {
        get
        {
            return this.vIPIDevolField;
        }
        set
        {
            this.vIPIDevolField = value;
        }
    }

    /// <remarks/>
    public decimal vPIS
    {
        get
        {
            return this.vPISField;
        }
        set
        {
            this.vPISField = value;
        }
    }

    /// <remarks/>
    public decimal vCOFINS
    {
        get
        {
            return this.vCOFINSField;
        }
        set
        {
            this.vCOFINSField = value;
        }
    }

    /// <remarks/>
    public decimal vOutro
    {
        get
        {
            return this.vOutroField;
        }
        set
        {
            this.vOutroField = value;
        }
    }

    /// <remarks/>
    public decimal vNF
    {
        get
        {
            return this.vNFField;
        }
        set
        {
            this.vNFField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeTransp
{

    private byte modFreteField;

    private nfeProcNFeInfNFeTranspVol volField;

    /// <remarks/>
    public byte modFrete
    {
        get
        {
            return this.modFreteField;
        }
        set
        {
            this.modFreteField = value;
        }
    }

    /// <remarks/>
    public nfeProcNFeInfNFeTranspVol vol
    {
        get
        {
            return this.volField;
        }
        set
        {
            this.volField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeTranspVol
{

    private byte qVolField;

    private string espField;

    private decimal pesoLField;

    private decimal pesoBField;

    /// <remarks/>
    public byte qVol
    {
        get
        {
            return this.qVolField;
        }
        set
        {
            this.qVolField = value;
        }
    }

    /// <remarks/>
    public string esp
    {
        get
        {
            return this.espField;
        }
        set
        {
            this.espField = value;
        }
    }

    /// <remarks/>
    public decimal pesoL
    {
        get
        {
            return this.pesoLField;
        }
        set
        {
            this.pesoLField = value;
        }
    }

    /// <remarks/>
    public decimal pesoB
    {
        get
        {
            return this.pesoBField;
        }
        set
        {
            this.pesoBField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeCobr
{

    private nfeProcNFeInfNFeCobrFat fatField;

    /// <remarks/>
    public nfeProcNFeInfNFeCobrFat fat
    {
        get
        {
            return this.fatField;
        }
        set
        {
            this.fatField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeCobrFat
{

    private ushort nFatField;

    private decimal vOrigField;

    private decimal vDescField;

    private decimal vLiqField;

    /// <remarks/>
    public ushort nFat
    {
        get
        {
            return this.nFatField;
        }
        set
        {
            this.nFatField = value;
        }
    }

    /// <remarks/>
    public decimal vOrig
    {
        get
        {
            return this.vOrigField;
        }
        set
        {
            this.vOrigField = value;
        }
    }

    /// <remarks/>
    public decimal vDesc
    {
        get
        {
            return this.vDescField;
        }
        set
        {
            this.vDescField = value;
        }
    }

    /// <remarks/>
    public decimal vLiq
    {
        get
        {
            return this.vLiqField;
        }
        set
        {
            this.vLiqField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFePag
{

    private nfeProcNFeInfNFePagDetPag detPagField;

    /// <remarks/>
    public nfeProcNFeInfNFePagDetPag detPag
    {
        get
        {
            return this.detPagField;
        }
        set
        {
            this.detPagField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFePagDetPag
{

    private byte indPagField;

    private byte tPagField;

    private decimal vPagField;

    /// <remarks/>
    public byte indPag
    {
        get
        {
            return this.indPagField;
        }
        set
        {
            this.indPagField = value;
        }
    }

    /// <remarks/>
    public byte tPag
    {
        get
        {
            return this.tPagField;
        }
        set
        {
            this.tPagField = value;
        }
    }

    /// <remarks/>
    public decimal vPag
    {
        get
        {
            return this.vPagField;
        }
        set
        {
            this.vPagField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeInfAdic
{

    private string infCplField;

    /// <remarks/>
    public string infCpl
    {
        get
        {
            return this.infCplField;
        }
        set
        {
            this.infCplField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcNFeInfNFeInfRespTec
{

    private ulong cNPJField;

    private string xContatoField;

    private string emailField;

    private uint foneField;

    /// <remarks/>
    public ulong CNPJ
    {
        get
        {
            return this.cNPJField;
        }
        set
        {
            this.cNPJField = value;
        }
    }

    /// <remarks/>
    public string xContato
    {
        get
        {
            return this.xContatoField;
        }
        set
        {
            this.xContatoField = value;
        }
    }

    /// <remarks/>
    public string email
    {
        get
        {
            return this.emailField;
        }
        set
        {
            this.emailField = value;
        }
    }

    /// <remarks/>
    public uint fone
    {
        get
        {
            return this.foneField;
        }
        set
        {
            this.foneField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public partial class Signature
{

    private SignatureSignedInfo signedInfoField;

    private string signatureValueField;

    private SignatureKeyInfo keyInfoField;

    /// <remarks/>
    public SignatureSignedInfo SignedInfo
    {
        get
        {
            return this.signedInfoField;
        }
        set
        {
            this.signedInfoField = value;
        }
    }

    /// <remarks/>
    public string SignatureValue
    {
        get
        {
            return this.signatureValueField;
        }
        set
        {
            this.signatureValueField = value;
        }
    }

    /// <remarks/>
    public SignatureKeyInfo KeyInfo
    {
        get
        {
            return this.keyInfoField;
        }
        set
        {
            this.keyInfoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureSignedInfo
{

    private SignatureSignedInfoCanonicalizationMethod canonicalizationMethodField;

    private SignatureSignedInfoSignatureMethod signatureMethodField;

    private SignatureSignedInfoReference referenceField;

    /// <remarks/>
    public SignatureSignedInfoCanonicalizationMethod CanonicalizationMethod
    {
        get
        {
            return this.canonicalizationMethodField;
        }
        set
        {
            this.canonicalizationMethodField = value;
        }
    }

    /// <remarks/>
    public SignatureSignedInfoSignatureMethod SignatureMethod
    {
        get
        {
            return this.signatureMethodField;
        }
        set
        {
            this.signatureMethodField = value;
        }
    }

    /// <remarks/>
    public SignatureSignedInfoReference Reference
    {
        get
        {
            return this.referenceField;
        }
        set
        {
            this.referenceField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureSignedInfoCanonicalizationMethod
{

    private string algorithmField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Algorithm
    {
        get
        {
            return this.algorithmField;
        }
        set
        {
            this.algorithmField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureSignedInfoSignatureMethod
{

    private string algorithmField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Algorithm
    {
        get
        {
            return this.algorithmField;
        }
        set
        {
            this.algorithmField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureSignedInfoReference
{

    private SignatureSignedInfoReferenceTransform[] transformsField;

    private SignatureSignedInfoReferenceDigestMethod digestMethodField;

    private string digestValueField;

    private string uRIField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
    public SignatureSignedInfoReferenceTransform[] Transforms
    {
        get
        {
            return this.transformsField;
        }
        set
        {
            this.transformsField = value;
        }
    }

    /// <remarks/>
    public SignatureSignedInfoReferenceDigestMethod DigestMethod
    {
        get
        {
            return this.digestMethodField;
        }
        set
        {
            this.digestMethodField = value;
        }
    }

    /// <remarks/>
    public string DigestValue
    {
        get
        {
            return this.digestValueField;
        }
        set
        {
            this.digestValueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string URI
    {
        get
        {
            return this.uRIField;
        }
        set
        {
            this.uRIField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureSignedInfoReferenceTransform
{

    private string algorithmField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Algorithm
    {
        get
        {
            return this.algorithmField;
        }
        set
        {
            this.algorithmField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureSignedInfoReferenceDigestMethod
{

    private string algorithmField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Algorithm
    {
        get
        {
            return this.algorithmField;
        }
        set
        {
            this.algorithmField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureKeyInfo
{

    private SignatureKeyInfoX509Data x509DataField;

    /// <remarks/>
    public SignatureKeyInfoX509Data X509Data
    {
        get
        {
            return this.x509DataField;
        }
        set
        {
            this.x509DataField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
public partial class SignatureKeyInfoX509Data
{

    private string x509CertificateField;

    /// <remarks/>
    public string X509Certificate
    {
        get
        {
            return this.x509CertificateField;
        }
        set
        {
            this.x509CertificateField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProtNFe
{

    private nfeProcProtNFeInfProt infProtField;

    private decimal versaoField;

    /// <remarks/>
    public nfeProcProtNFeInfProt infProt
    {
        get
        {
            return this.infProtField;
        }
        set
        {
            this.infProtField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal versao
    {
        get
        {
            return this.versaoField;
        }
        set
        {
            this.versaoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class nfeProcProtNFeInfProt
{

    private byte tpAmbField;

    private string verAplicField;

    private string chNFeField;

    private System.DateTime dhRecbtoField;

    private ulong nProtField;

    private string digValField;

    private byte cStatField;

    private string xMotivoField;

    /// <remarks/>
    public byte tpAmb
    {
        get
        {
            return this.tpAmbField;
        }
        set
        {
            this.tpAmbField = value;
        }
    }

    /// <remarks/>
    public string verAplic
    {
        get
        {
            return this.verAplicField;
        }
        set
        {
            this.verAplicField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
    public string chNFe
    {
        get
        {
            return this.chNFeField;
        }
        set
        {
            this.chNFeField = value;
        }
    }

    /// <remarks/>
    public System.DateTime dhRecbto
    {
        get
        {
            return this.dhRecbtoField;
        }
        set
        {
            this.dhRecbtoField = value;
        }
    }

    /// <remarks/>
    public ulong nProt
    {
        get
        {
            return this.nProtField;
        }
        set
        {
            this.nProtField = value;
        }
    }

    /// <remarks/>
    public string digVal
    {
        get
        {
            return this.digValField;
        }
        set
        {
            this.digValField = value;
        }
    }

    /// <remarks/>
    public byte cStat
    {
        get
        {
            return this.cStatField;
        }
        set
        {
            this.cStatField = value;
        }
    }

    /// <remarks/>
    public string xMotivo
    {
        get
        {
            return this.xMotivoField;
        }
        set
        {
            this.xMotivoField = value;
        }
    }
}

public class DescerializarXml{
    
    public List<dynamic> GetXml(string xmlOuCaminho)
    {
        List<dynamic> dynamics = new List<dynamic>();
        XmlDocument xElem = new XmlDocument();
        xElem.LoadXml(xmlOuCaminho);
        string cpf= xElem.GetElementsByTagName("CPF")[0].InnerText;
        dynamic obj = new {
            Cpf = cpf
        };
        var elemento = xElem.GetElementsByTagName("det");
        for(int i = 0; i < elemento.Count; i++)
        {
            XmlDocument xElem2 = new XmlDocument();
            xElem2.LoadXml(elemento[i].InnerText);
            var node = xElem2.GetElementsByTagName("prod");
            var elemento2 = node[0]["cEAN"];
            for(int j=0; j< node.Count; j++)
            {
                obj = new
                {
                    CodBarra = node[i]["cEAN"].InnerText
                };
                dynamics.Add(obj);
            }

        }
        return dynamics;
    }
}