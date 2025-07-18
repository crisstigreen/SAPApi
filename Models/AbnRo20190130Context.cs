using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SAPApi.Models;

public partial class AbnRo20190130Context : DbContext
{
    public AbnRo20190130Context()
    {
    }

    public AbnRo20190130Context(DbContextOptions<AbnRo20190130Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Oacp> Oacps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=185.232.66.77;Database=ABN_RO_20190130;User Id=sa;Password=Vghn1234;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP850_CI_AS");

        modelBuilder.Entity<Oacp>(entity =>
        {
            entity.HasKey(e => e.AbsEntry).HasName("OACP_PRIMARY");

            entity.ToTable("OACP");

            entity.HasIndex(e => e.PeriodCat, "OACP_CATEGORY").IsUnique();

            entity.Property(e => e.AlocCstAct).HasMaxLength(15);
            entity.Property(e => e.AmountDiff).HasMaxLength(15);
            entity.Property(e => e.Apcmact)
                .HasMaxLength(15)
                .HasColumnName("APCMAct");
            entity.Property(e => e.Apcmeuact)
                .HasMaxLength(15)
                .HasColumnName("APCMEUAct");
            entity.Property(e => e.ApcmfrnAct)
                .HasMaxLength(15)
                .HasColumnName("APCMFrnAct");
            entity.Property(e => e.ApconDiffG)
                .HasMaxLength(15)
                .HasColumnName("APConDiffG");
            entity.Property(e => e.ApconDiffL)
                .HasMaxLength(15)
                .HasColumnName("APConDiffL");
            entity.Property(e => e.Arcmact)
                .HasMaxLength(15)
                .HasColumnName("ARCMAct");
            entity.Property(e => e.Arcmeuact)
                .HasMaxLength(15)
                .HasColumnName("ARCMEUAct");
            entity.Property(e => e.ArcmexpAct)
                .HasMaxLength(15)
                .HasColumnName("ARCMExpAct");
            entity.Property(e => e.ArcmfrnAct)
                .HasMaxLength(15)
                .HasColumnName("ARCMFrnAct");
            entity.Property(e => e.ArconDiffG)
                .HasMaxLength(15)
                .HasColumnName("ARConDiffG");
            entity.Property(e => e.ArconDiffL)
                .HasMaxLength(15)
                .HasColumnName("ARConDiffL");
            entity.Property(e => e.BalanceAct).HasMaxLength(15);
            entity.Property(e => e.BnkChgAct).HasMaxLength(15);
            entity.Property(e => e.CboEdiscnt)
                .HasMaxLength(15)
                .HasColumnName("CBoEDiscnt");
            entity.Property(e => e.CboEonClct)
                .HasMaxLength(15)
                .HasColumnName("CBoEOnClct");
            entity.Property(e => e.CboEpresnt)
                .HasMaxLength(15)
                .HasColumnName("CBoEPresnt");
            entity.Property(e => e.CboErcvble)
                .HasMaxLength(15)
                .HasColumnName("CBoERcvble");
            entity.Property(e => e.CdownPymnt)
                .HasMaxLength(15)
                .HasColumnName("CDownPymnt");
            entity.Property(e => e.CogmAct)
                .HasMaxLength(15)
                .HasColumnName("COGM_Act");
            entity.Property(e => e.ComissAct).HasMaxLength(15);
            entity.Property(e => e.CopenDebts)
                .HasMaxLength(15)
                .HasColumnName("COpenDebts");
            entity.Property(e => e.CostOffAct).HasMaxLength(15);
            entity.Property(e => e.CostRevAct).HasMaxLength(15);
            entity.Property(e => e.CsdinApact)
                .HasMaxLength(15)
                .HasColumnName("CSDInAPAct");
            entity.Property(e => e.CsdinAract)
                .HasMaxLength(15)
                .HasColumnName("CSDInARAct");
            entity.Property(e => e.CunpaidBoE)
                .HasMaxLength(15)
                .HasColumnName("CUnpaidBoE");
            entity.Property(e => e.DecresGlAc).HasMaxLength(15);
            entity.Property(e => e.DflInPrcss).HasMaxLength(15);
            entity.Property(e => e.DfltCard).HasMaxLength(15);
            entity.Property(e => e.DfltExpn).HasMaxLength(15);
            entity.Property(e => e.DfltInCstm).HasMaxLength(15);
            entity.Property(e => e.DfltIncom).HasMaxLength(15);
            entity.Property(e => e.DfltLoss).HasMaxLength(15);
            entity.Property(e => e.DfltProfit).HasMaxLength(15);
            entity.Property(e => e.DfltRateDi).HasMaxLength(15);
            entity.Property(e => e.DftStockOb)
                .HasMaxLength(15)
                .HasColumnName("DftStockOB");
            entity.Property(e => e.DpmPurAct).HasMaxLength(15);
            entity.Property(e => e.DpmSalAct).HasMaxLength(15);
            entity.Property(e => e.DunFee).HasMaxLength(15);
            entity.Property(e => e.DunIntrst).HasMaxLength(15);
            entity.Property(e => e.Ecexepnses)
                .HasMaxLength(15)
                .HasColumnName("ECExepnses");
            entity.Property(e => e.Ecincome)
                .HasMaxLength(15)
                .HasColumnName("ECIncome");
            entity.Property(e => e.ErdinApact)
                .HasMaxLength(15)
                .HasColumnName("ERDInAPAct");
            entity.Property(e => e.ErdinAract)
                .HasMaxLength(15)
                .HasColumnName("ERDInARAct");
            entity.Property(e => e.EupayAct)
                .HasMaxLength(15)
                .HasColumnName("EUPayAct");
            entity.Property(e => e.EurecvAct)
                .HasMaxLength(15)
                .HasColumnName("EURecvAct");
            entity.Property(e => e.ExDiffAct).HasMaxLength(15);
            entity.Property(e => e.ExmptIncom).HasMaxLength(15);
            entity.Property(e => e.ExpClrAct).HasMaxLength(15);
            entity.Property(e => e.ExpOfstAct).HasMaxLength(15);
            entity.Property(e => e.ExpVarAct).HasMaxLength(15);
            entity.Property(e => e.ExpnAcct).HasMaxLength(15);
            entity.Property(e => e.ExrateOnDt).HasMaxLength(15);
            entity.Property(e => e.FDueDate)
                .HasColumnType("datetime")
                .HasColumnName("F_DueDate");
            entity.Property(e => e.FRefDate)
                .HasColumnType("datetime")
                .HasColumnName("F_RefDate");
            entity.Property(e => e.FTaxDate)
                .HasColumnType("datetime")
                .HasColumnName("F_TaxDate");
            entity.Property(e => e.FinancYear).HasColumnType("datetime");
            entity.Property(e => e.ForgnExpn).HasMaxLength(15);
            entity.Property(e => e.ForgnIncm).HasMaxLength(15);
            entity.Property(e => e.FreeChrgPu)
                .HasMaxLength(15)
                .HasColumnName("FreeChrgPU");
            entity.Property(e => e.FreeChrgSa)
                .HasMaxLength(15)
                .HasColumnName("FreeChrgSA");
            entity.Property(e => e.GlRvOffAct).HasMaxLength(15);
            entity.Property(e => e.GlconDiffG)
                .HasMaxLength(15)
                .HasColumnName("GLConDiffG");
            entity.Property(e => e.GlconDiffL)
                .HasMaxLength(15)
                .HasColumnName("GLConDiffL");
            entity.Property(e => e.GlgainXdif)
                .HasMaxLength(15)
                .HasColumnName("GLGainXdif");
            entity.Property(e => e.GllossXdif)
                .HasMaxLength(15)
                .HasColumnName("GLLossXdif");
            entity.Property(e => e.Gstcharges)
                .HasMaxLength(15)
                .HasColumnName("GSTCharges");
            entity.Property(e => e.Gstfee)
                .HasMaxLength(15)
                .HasColumnName("GSTFee");
            entity.Property(e => e.GstinAct)
                .HasMaxLength(15)
                .HasColumnName("GSTInAct");
            entity.Property(e => e.Gstinterst)
                .HasMaxLength(15)
                .HasColumnName("GSTInterst");
            entity.Property(e => e.IcclrAct)
                .HasMaxLength(15)
                .HasColumnName("ICClrAct");
            entity.Property(e => e.IncmAcct).HasMaxLength(15);
            entity.Property(e => e.IncresGlAc).HasMaxLength(15);
            entity.Property(e => e.LinkAct1)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_1");
            entity.Property(e => e.LinkAct10)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_10");
            entity.Property(e => e.LinkAct11)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_11");
            entity.Property(e => e.LinkAct12)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_12");
            entity.Property(e => e.LinkAct13)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_13");
            entity.Property(e => e.LinkAct14)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_14");
            entity.Property(e => e.LinkAct15)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_15");
            entity.Property(e => e.LinkAct16)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_16");
            entity.Property(e => e.LinkAct17)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_17");
            entity.Property(e => e.LinkAct18)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_18");
            entity.Property(e => e.LinkAct19)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_19");
            entity.Property(e => e.LinkAct2)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_2");
            entity.Property(e => e.LinkAct20)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_20");
            entity.Property(e => e.LinkAct21)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_21");
            entity.Property(e => e.LinkAct22)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_22");
            entity.Property(e => e.LinkAct23)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_23");
            entity.Property(e => e.LinkAct24)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_24");
            entity.Property(e => e.LinkAct25)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_25");
            entity.Property(e => e.LinkAct26)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_26");
            entity.Property(e => e.LinkAct27)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_27");
            entity.Property(e => e.LinkAct28)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_28");
            entity.Property(e => e.LinkAct29)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_29");
            entity.Property(e => e.LinkAct3)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_3");
            entity.Property(e => e.LinkAct30)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_30");
            entity.Property(e => e.LinkAct4)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_4");
            entity.Property(e => e.LinkAct5)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_5");
            entity.Property(e => e.LinkAct6)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_6");
            entity.Property(e => e.LinkAct8)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_8");
            entity.Property(e => e.LinkAct9)
                .HasMaxLength(15)
                .HasColumnName("LinkAct_9");
            entity.Property(e => e.NegStckAct).HasMaxLength(15);
            entity.Property(e => e.OcclrAct)
                .HasMaxLength(15)
                .HasColumnName("OCClrAct");
            entity.Property(e => e.OnHoldAct).HasMaxLength(15);
            entity.Property(e => e.OverpayAp)
                .HasMaxLength(15)
                .HasColumnName("OverpayAP");
            entity.Property(e => e.OverpayAr)
                .HasMaxLength(15)
                .HasColumnName("OverpayAR");
            entity.Property(e => e.PaOffsetAc).HasMaxLength(15);
            entity.Property(e => e.PaReturnAc).HasMaxLength(15);
            entity.Property(e => e.PeriodCat).HasMaxLength(10);
            entity.Property(e => e.PeriodName).HasMaxLength(20);
            entity.Property(e => e.PlaAct).HasMaxLength(15);
            entity.Property(e => e.PricDifAct).HasMaxLength(15);
            entity.Property(e => e.PurBalAct).HasMaxLength(15);
            entity.Property(e => e.PurDpmInt).HasMaxLength(15);
            entity.Property(e => e.PurcVatOff).HasMaxLength(15);
            entity.Property(e => e.PurchseAct).HasMaxLength(15);
            entity.Property(e => e.RepomoAct).HasMaxLength(15);
            entity.Property(e => e.ResExpense).HasMaxLength(15);
            entity.Property(e => e.ResNotInv).HasMaxLength(15);
            entity.Property(e => e.ResOffPlAc).HasMaxLength(15);
            entity.Property(e => e.ResPurchCr).HasMaxLength(15);
            entity.Property(e => e.ResRevenue).HasMaxLength(15);
            entity.Property(e => e.ResSalesCr).HasMaxLength(15);
            entity.Property(e => e.ResScrapAc).HasMaxLength(15);
            entity.Property(e => e.ResStdEx10).HasMaxLength(15);
            entity.Property(e => e.ResStdExp1).HasMaxLength(15);
            entity.Property(e => e.ResStdExp2).HasMaxLength(15);
            entity.Property(e => e.ResStdExp3).HasMaxLength(15);
            entity.Property(e => e.ResStdExp4).HasMaxLength(15);
            entity.Property(e => e.ResStdExp5).HasMaxLength(15);
            entity.Property(e => e.ResStdExp6).HasMaxLength(15);
            entity.Property(e => e.ResStdExp7).HasMaxLength(15);
            entity.Property(e => e.ResStdExp8).HasMaxLength(15);
            entity.Property(e => e.ResStdExp9).HasMaxLength(15);
            entity.Property(e => e.ResWipAct).HasMaxLength(15);
            entity.Property(e => e.RturnngAct).HasMaxLength(15);
            entity.Property(e => e.SalDpmInt).HasMaxLength(15);
            entity.Property(e => e.SaleVatOff).HasMaxLength(15);
            entity.Property(e => e.ShpdGdsAct).HasMaxLength(15);
            entity.Property(e => e.SlfInvExpn).HasMaxLength(15);
            entity.Property(e => e.SlfInvIncm).HasMaxLength(15);
            entity.Property(e => e.SnapShotId).HasDefaultValue(0);
            entity.Property(e => e.SrvTaxClr).HasMaxLength(15);
            entity.Property(e => e.StkInTnAct).HasMaxLength(15);
            entity.Property(e => e.StkRvOfAct).HasMaxLength(15);
            entity.Property(e => e.StockAct).HasMaxLength(15);
            entity.Property(e => e.StockOffst).HasMaxLength(15);
            entity.Property(e => e.StockRvAct).HasMaxLength(15);
            entity.Property(e => e.SubType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("Y")
                .IsFixedLength();
            entity.Property(e => e.TDueDate)
                .HasColumnType("datetime")
                .HasColumnName("T_DueDate");
            entity.Property(e => e.TRefDate)
                .HasColumnType("datetime")
                .HasColumnName("T_RefDate");
            entity.Property(e => e.TTaxDate)
                .HasColumnType("datetime")
                .HasColumnName("T_TaxDate");
            entity.Property(e => e.Tdscharges)
                .HasMaxLength(15)
                .HasColumnName("TDSCharges");
            entity.Property(e => e.Tdsfee)
                .HasMaxLength(15)
                .HasColumnName("TDSFee");
            entity.Property(e => e.Tdsinterst)
                .HasMaxLength(15)
                .HasColumnName("TDSInterst");
            entity.Property(e => e.UndrpayAp)
                .HasMaxLength(15)
                .HasColumnName("UndrpayAP");
            entity.Property(e => e.UndrpayAr)
                .HasMaxLength(15)
                .HasColumnName("UndrpayAR");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.VariancAct).HasMaxLength(15);
            entity.Property(e => e.Vassets)
                .HasMaxLength(15)
                .HasColumnName("VAssets");
            entity.Property(e => e.VasstBoEpy)
                .HasMaxLength(15)
                .HasColumnName("VAsstBoEPy");
            entity.Property(e => e.VatRevAct).HasMaxLength(15);
            entity.Property(e => e.VboEpayble)
                .HasMaxLength(15)
                .HasColumnName("VBoEPayble");
            entity.Property(e => e.VdownPymnt)
                .HasMaxLength(15)
                .HasColumnName("VDownPymnt");
            entity.Property(e => e.VopenDebts)
                .HasMaxLength(15)
                .HasColumnName("VOpenDebts");
            entity.Property(e => e.WhIcenAct)
                .HasMaxLength(15)
                .HasColumnName("WhICenAct");
            entity.Property(e => e.WhOcenAct)
                .HasMaxLength(15)
                .HasColumnName("WhOCenAct");
            entity.Property(e => e.WipAcct).HasMaxLength(15);
            entity.Property(e => e.WipOffPlAc).HasMaxLength(15);
            entity.Property(e => e.WipOffset).HasMaxLength(15);
            entity.Property(e => e.WipVarAcct).HasMaxLength(15);
            entity.Property(e => e.WtexDifAct)
                .HasMaxLength(15)
                .HasColumnName("WTExDifAct");
            entity.Property(e => e.WtinApact)
                .HasMaxLength(15)
                .HasColumnName("WTInAPAct");
            entity.Property(e => e.WtinAract)
                .HasMaxLength(15)
                .HasColumnName("WTInARAct");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
