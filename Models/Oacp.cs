using System;
using System.Collections.Generic;

namespace SAPApi.Models;

public partial class Oacp
{
    public int AbsEntry { get; set; }

    public string PeriodCat { get; set; } = null!;

    public DateTime? FinancYear { get; set; }

    public short? Year { get; set; }

    public string? PeriodName { get; set; }

    public string? SubType { get; set; }

    public int? PeriodNum { get; set; }

    public DateTime? FRefDate { get; set; }

    public DateTime? TRefDate { get; set; }

    public DateTime? FDueDate { get; set; }

    public DateTime? TDueDate { get; set; }

    public DateTime? FTaxDate { get; set; }

    public DateTime? TTaxDate { get; set; }

    public int? LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public short? UserSign { get; set; }

    public string? LinkAct1 { get; set; }

    public string? LinkAct2 { get; set; }

    public string? LinkAct3 { get; set; }

    public string? LinkAct4 { get; set; }

    public string? LinkAct5 { get; set; }

    public string? LinkAct6 { get; set; }

    public string? ComissAct { get; set; }

    public string? LinkAct8 { get; set; }

    public string? LinkAct9 { get; set; }

    public string? LinkAct10 { get; set; }

    public string? LinkAct11 { get; set; }

    public string? LinkAct12 { get; set; }

    public string? LinkAct13 { get; set; }

    public string? LinkAct14 { get; set; }

    public string? LinkAct15 { get; set; }

    public string? LinkAct16 { get; set; }

    public string? LinkAct17 { get; set; }

    public string? LinkAct18 { get; set; }

    public string? DfltIncom { get; set; }

    public string? ExmptIncom { get; set; }

    public string? DfltExpn { get; set; }

    public string? ForgnIncm { get; set; }

    public string? Ecincome { get; set; }

    public string? ForgnExpn { get; set; }

    public string? DfltRateDi { get; set; }

    public string? DecresGlAc { get; set; }

    public string? LinkAct27 { get; set; }

    public string? DftStockOb { get; set; }

    public string? LinkAct19 { get; set; }

    public string? LinkAct20 { get; set; }

    public string? LinkAct21 { get; set; }

    public string? LinkAct22 { get; set; }

    public string? LinkAct23 { get; set; }

    public string? LinkAct24 { get; set; }

    public string? LinkAct25 { get; set; }

    public string? LinkAct26 { get; set; }

    public string? IncresGlAc { get; set; }

    public string? RturnngAct { get; set; }

    public string? CogmAct { get; set; }

    public string? AlocCstAct { get; set; }

    public string? VariancAct { get; set; }

    public string? PricDifAct { get; set; }

    public string? CdownPymnt { get; set; }

    public string? VdownPymnt { get; set; }

    public string? CboErcvble { get; set; }

    public string? CboEonClct { get; set; }

    public string? CboEpresnt { get; set; }

    public string? CboEdiscnt { get; set; }

    public string? CunpaidBoE { get; set; }

    public string? VboEpayble { get; set; }

    public string? VasstBoEpy { get; set; }

    public string? CopenDebts { get; set; }

    public string? VopenDebts { get; set; }

    public string? PurchseAct { get; set; }

    public string? PaReturnAc { get; set; }

    public string? PaOffsetAc { get; set; }

    public string? LinkAct28 { get; set; }

    public string? ExDiffAct { get; set; }

    public string? BalanceAct { get; set; }

    public string? BnkChgAct { get; set; }

    public string? LinkAct29 { get; set; }

    public string? LinkAct30 { get; set; }

    public string? IncmAcct { get; set; }

    public string? ExpnAcct { get; set; }

    public string? VatRevAct { get; set; }

    public string? ExpClrAct { get; set; }

    public string? ExpOfstAct { get; set; }

    public string? CostRevAct { get; set; }

    public string? RepomoAct { get; set; }

    public string? WipVarAcct { get; set; }

    public string? SaleVatOff { get; set; }

    public string? PurcVatOff { get; set; }

    public string? DpmSalAct { get; set; }

    public string? DpmPurAct { get; set; }

    public string? ExpVarAct { get; set; }

    public string? CostOffAct { get; set; }

    public string? Ecexepnses { get; set; }

    public string? StockAct { get; set; }

    public string? DflInPrcss { get; set; }

    public string? DfltInCstm { get; set; }

    public string? DfltProfit { get; set; }

    public string? DfltLoss { get; set; }

    public string? Vassets { get; set; }

    public string? StockRvAct { get; set; }

    public string? StkRvOfAct { get; set; }

    public string? WipAcct { get; set; }

    public string? DfltCard { get; set; }

    public string? ShpdGdsAct { get; set; }

    public string? GlRvOffAct { get; set; }

    public string? OverpayAp { get; set; }

    public string? UndrpayAp { get; set; }

    public string? OverpayAr { get; set; }

    public string? UndrpayAr { get; set; }

    public string? Arcmact { get; set; }

    public string? ArcmexpAct { get; set; }

    public string? ArcmfrnAct { get; set; }

    public string? Arcmeuact { get; set; }

    public string? Apcmact { get; set; }

    public string? ApcmfrnAct { get; set; }

    public string? Apcmeuact { get; set; }

    public string? NegStckAct { get; set; }

    public string? StkInTnAct { get; set; }

    public string? GlgainXdif { get; set; }

    public string? GllossXdif { get; set; }

    public string? AmountDiff { get; set; }

    public string? SlfInvIncm { get; set; }

    public string? SlfInvExpn { get; set; }

    public string? OnHoldAct { get; set; }

    public string? PlaAct { get; set; }

    public string? IcclrAct { get; set; }

    public string? OcclrAct { get; set; }

    public string? PurBalAct { get; set; }

    public string? WhIcenAct { get; set; }

    public string? WhOcenAct { get; set; }

    public string? SalDpmInt { get; set; }

    public string? PurDpmInt { get; set; }

    public string? ExrateOnDt { get; set; }

    public short? UserSign2 { get; set; }

    public string? EurecvAct { get; set; }

    public string? EupayAct { get; set; }

    public string? WipOffset { get; set; }

    public string? StockOffst { get; set; }

    public string? DunIntrst { get; set; }

    public string? DunFee { get; set; }

    public int? SnapShotId { get; set; }

    public string? Tdsinterst { get; set; }

    public string? Tdscharges { get; set; }

    public string? SrvTaxClr { get; set; }

    public string? ArconDiffG { get; set; }

    public string? ArconDiffL { get; set; }

    public string? ApconDiffG { get; set; }

    public string? ApconDiffL { get; set; }

    public string? GlconDiffG { get; set; }

    public string? GlconDiffL { get; set; }

    public string? FreeChrgSa { get; set; }

    public string? FreeChrgPu { get; set; }

    public string? Tdsfee { get; set; }

    public string? ResRevenue { get; set; }

    public string? ResExpense { get; set; }

    public string? ResSalesCr { get; set; }

    public string? ResPurchCr { get; set; }

    public string? ResNotInv { get; set; }

    public string? ResStdExp1 { get; set; }

    public string? ResStdExp2 { get; set; }

    public string? ResStdExp3 { get; set; }

    public string? ResStdExp4 { get; set; }

    public string? ResStdExp5 { get; set; }

    public string? ResStdExp6 { get; set; }

    public string? ResStdExp7 { get; set; }

    public string? ResStdExp8 { get; set; }

    public string? ResStdExp9 { get; set; }

    public string? ResStdEx10 { get; set; }

    public string? ResWipAct { get; set; }

    public string? ResScrapAc { get; set; }

    public string? WipOffPlAc { get; set; }

    public string? ResOffPlAc { get; set; }

    public string? ErdinAract { get; set; }

    public string? ErdinApact { get; set; }

    public string? CsdinAract { get; set; }

    public string? CsdinApact { get; set; }

    public string? GstinAct { get; set; }

    public string? Gstinterst { get; set; }

    public string? Gstcharges { get; set; }

    public string? Gstfee { get; set; }

    public string? WtinAract { get; set; }

    public string? WtinApact { get; set; }

    public string? WtexDifAct { get; set; }
}
