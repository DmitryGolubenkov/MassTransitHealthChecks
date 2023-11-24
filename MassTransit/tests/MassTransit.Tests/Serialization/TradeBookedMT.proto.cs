// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Events/TradeBookedMT.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MassTransit.Tests.Serialization {

  /// <summary>Holder for reflection information generated from Events/TradeBookedMT.proto</summary>
  public static partial class TradeBookedMTReflection {

    #region Descriptor
    /// <summary>File descriptor for Events/TradeBookedMT.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TradeBookedMTReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpFdmVudHMvVHJhZGVCb29rZWRNVC5wcm90bxIPTWVzc2FnZXMuRXZlbnRz",
            "Gh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvIv4ECg1UcmFkZUJv",
            "b2tlZE1UEhAKCHRyYWRlX2lkGAEgASgJEhkKEWV4Y2hhbmdlX29yZGVyX2lk",
            "GAIgASgJEg4KBnN5c3RlbRgDIAEoCRIUCgxjb3VudGVycGFydHkYBCABKAkS",
            "FAoMcG9ydGZvbGlvX2lkGAUgASgJEg4KBnZvbHVtZRgHIAEoARIVCg1pbnN0",
            "cnVtZW50X2lkGAggASgJEg0KBXByaWNlGAkgASgBEhAKCGN1cnJlbmN5GAog",
            "ASgJEi0KCXRpbWVzdGFtcBgLIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1l",
            "c3RhbXASSwoPYWRkaXRpb25hbF9kYXRhGAwgAygLMjIuTWVzc2FnZXMuRXZl",
            "bnRzLlRyYWRlQm9va2VkTVQuQWRkaXRpb25hbERhdGFFbnRyeRIXCg9zeXN0",
            "ZW1fdHJhZGVfaWQYDSABKAkSFwoPdW5pcXVlX3RyYWRlX2lkGA4gASgJEgwK",
            "BGRlc2sYDyABKAkSGQoRZXhjaGFuZ2VfdHJhZGVfaWQYECABKAkSFAoMbWFy",
            "a2V0X3RyYWRlGBEgASgIEg8KB2FsZ29faWQYEiABKAkSEAoIc3RyYXRlZ3kY",
            "EyABKAkSDQoFb3duZXIYFCABKAkSFwoPY2xlYXJlcl9hY2NvdW50GBUgASgJ",
            "Eg0KBWRlcG90GBYgASgJEhMKC3NhZmVrZWVwaW5nGBcgASgJEg8KB2RlbGV0",
            "ZWQYGCABKAgSGAoQZnVuZGluZ19jdXJyZW5jeRgZIAEoCRo1ChNBZGRpdGlv",
            "bmFsRGF0YUVudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoCToCOAFi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MassTransit.Tests.Serialization.TradeBookedMT), global::MassTransit.Tests.Serialization.TradeBookedMT.Parser, new[]{ "TradeId", "ExchangeOrderId", "System", "Counterparty", "PortfolioId", "Volume", "InstrumentId", "Price", "Currency", "Timestamp", "AdditionalData", "SystemTradeId", "UniqueTradeId", "Desk", "ExchangeTradeId", "MarketTrade", "AlgoId", "Strategy", "Owner", "ClearerAccount", "Depot", "Safekeeping", "Deleted", "FundingCurrency" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TradeBookedMT : pb::IMessage<TradeBookedMT> {
    private static readonly pb::MessageParser<TradeBookedMT> _parser = new pb::MessageParser<TradeBookedMT>(() => new TradeBookedMT());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TradeBookedMT> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MassTransit.Tests.Serialization.TradeBookedMTReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TradeBookedMT() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TradeBookedMT(TradeBookedMT other) : this() {
      tradeId_ = other.tradeId_;
      exchangeOrderId_ = other.exchangeOrderId_;
      system_ = other.system_;
      counterparty_ = other.counterparty_;
      portfolioId_ = other.portfolioId_;
      volume_ = other.volume_;
      instrumentId_ = other.instrumentId_;
      price_ = other.price_;
      currency_ = other.currency_;
      timestamp_ = other.timestamp_ != null ? other.timestamp_.Clone() : null;
      additionalData_ = other.additionalData_.Clone();
      systemTradeId_ = other.systemTradeId_;
      uniqueTradeId_ = other.uniqueTradeId_;
      desk_ = other.desk_;
      exchangeTradeId_ = other.exchangeTradeId_;
      marketTrade_ = other.marketTrade_;
      algoId_ = other.algoId_;
      strategy_ = other.strategy_;
      owner_ = other.owner_;
      clearerAccount_ = other.clearerAccount_;
      depot_ = other.depot_;
      safekeeping_ = other.safekeeping_;
      deleted_ = other.deleted_;
      fundingCurrency_ = other.fundingCurrency_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TradeBookedMT Clone() {
      return new TradeBookedMT(this);
    }

    /// <summary>Field number for the "trade_id" field.</summary>
    public const int TradeIdFieldNumber = 1;
    private string tradeId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TradeId {
      get { return tradeId_; }
      set {
        tradeId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "exchange_order_id" field.</summary>
    public const int ExchangeOrderIdFieldNumber = 2;
    private string exchangeOrderId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExchangeOrderId {
      get { return exchangeOrderId_; }
      set {
        exchangeOrderId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "system" field.</summary>
    public const int SystemFieldNumber = 3;
    private string system_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string System {
      get { return system_; }
      set {
        system_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "counterparty" field.</summary>
    public const int CounterpartyFieldNumber = 4;
    private string counterparty_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Counterparty {
      get { return counterparty_; }
      set {
        counterparty_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "portfolio_id" field.</summary>
    public const int PortfolioIdFieldNumber = 5;
    private string portfolioId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PortfolioId {
      get { return portfolioId_; }
      set {
        portfolioId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "volume" field.</summary>
    public const int VolumeFieldNumber = 7;
    private double volume_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Volume {
      get { return volume_; }
      set {
        volume_ = value;
      }
    }

    /// <summary>Field number for the "instrument_id" field.</summary>
    public const int InstrumentIdFieldNumber = 8;
    private string instrumentId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InstrumentId {
      get { return instrumentId_; }
      set {
        instrumentId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "price" field.</summary>
    public const int PriceFieldNumber = 9;
    private double price_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Price {
      get { return price_; }
      set {
        price_ = value;
      }
    }

    /// <summary>Field number for the "currency" field.</summary>
    public const int CurrencyFieldNumber = 10;
    private string currency_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Currency {
      get { return currency_; }
      set {
        currency_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 11;
    private global::Google.Protobuf.WellKnownTypes.Timestamp timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "additional_data" field.</summary>
    public const int AdditionalDataFieldNumber = 12;
    private static readonly pbc::MapField<string, string>.Codec _map_additionalData_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 98);
    private readonly pbc::MapField<string, string> additionalData_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> AdditionalData {
      get { return additionalData_; }
    }

    /// <summary>Field number for the "system_trade_id" field.</summary>
    public const int SystemTradeIdFieldNumber = 13;
    private string systemTradeId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SystemTradeId {
      get { return systemTradeId_; }
      set {
        systemTradeId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "unique_trade_id" field.</summary>
    public const int UniqueTradeIdFieldNumber = 14;
    private string uniqueTradeId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UniqueTradeId {
      get { return uniqueTradeId_; }
      set {
        uniqueTradeId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "desk" field.</summary>
    public const int DeskFieldNumber = 15;
    private string desk_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Desk {
      get { return desk_; }
      set {
        desk_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "exchange_trade_id" field.</summary>
    public const int ExchangeTradeIdFieldNumber = 16;
    private string exchangeTradeId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExchangeTradeId {
      get { return exchangeTradeId_; }
      set {
        exchangeTradeId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "market_trade" field.</summary>
    public const int MarketTradeFieldNumber = 17;
    private bool marketTrade_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool MarketTrade {
      get { return marketTrade_; }
      set {
        marketTrade_ = value;
      }
    }

    /// <summary>Field number for the "algo_id" field.</summary>
    public const int AlgoIdFieldNumber = 18;
    private string algoId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AlgoId {
      get { return algoId_; }
      set {
        algoId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "strategy" field.</summary>
    public const int StrategyFieldNumber = 19;
    private string strategy_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Strategy {
      get { return strategy_; }
      set {
        strategy_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "owner" field.</summary>
    public const int OwnerFieldNumber = 20;
    private string owner_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Owner {
      get { return owner_; }
      set {
        owner_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "clearer_account" field.</summary>
    public const int ClearerAccountFieldNumber = 21;
    private string clearerAccount_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClearerAccount {
      get { return clearerAccount_; }
      set {
        clearerAccount_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "depot" field.</summary>
    public const int DepotFieldNumber = 22;
    private string depot_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Depot {
      get { return depot_; }
      set {
        depot_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "safekeeping" field.</summary>
    public const int SafekeepingFieldNumber = 23;
    private string safekeeping_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Safekeeping {
      get { return safekeeping_; }
      set {
        safekeeping_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "deleted" field.</summary>
    public const int DeletedFieldNumber = 24;
    private bool deleted_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Deleted {
      get { return deleted_; }
      set {
        deleted_ = value;
      }
    }

    /// <summary>Field number for the "funding_currency" field.</summary>
    public const int FundingCurrencyFieldNumber = 25;
    private string fundingCurrency_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FundingCurrency {
      get { return fundingCurrency_; }
      set {
        fundingCurrency_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TradeBookedMT);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TradeBookedMT other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TradeId != other.TradeId) return false;
      if (ExchangeOrderId != other.ExchangeOrderId) return false;
      if (System != other.System) return false;
      if (Counterparty != other.Counterparty) return false;
      if (PortfolioId != other.PortfolioId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Volume, other.Volume)) return false;
      if (InstrumentId != other.InstrumentId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Price, other.Price)) return false;
      if (Currency != other.Currency) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      if (!AdditionalData.Equals(other.AdditionalData)) return false;
      if (SystemTradeId != other.SystemTradeId) return false;
      if (UniqueTradeId != other.UniqueTradeId) return false;
      if (Desk != other.Desk) return false;
      if (ExchangeTradeId != other.ExchangeTradeId) return false;
      if (MarketTrade != other.MarketTrade) return false;
      if (AlgoId != other.AlgoId) return false;
      if (Strategy != other.Strategy) return false;
      if (Owner != other.Owner) return false;
      if (ClearerAccount != other.ClearerAccount) return false;
      if (Depot != other.Depot) return false;
      if (Safekeeping != other.Safekeeping) return false;
      if (Deleted != other.Deleted) return false;
      if (FundingCurrency != other.FundingCurrency) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TradeId.Length != 0) hash ^= TradeId.GetHashCode();
      if (ExchangeOrderId.Length != 0) hash ^= ExchangeOrderId.GetHashCode();
      if (System.Length != 0) hash ^= System.GetHashCode();
      if (Counterparty.Length != 0) hash ^= Counterparty.GetHashCode();
      if (PortfolioId.Length != 0) hash ^= PortfolioId.GetHashCode();
      if (Volume != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Volume);
      if (InstrumentId.Length != 0) hash ^= InstrumentId.GetHashCode();
      if (Price != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Price);
      if (Currency.Length != 0) hash ^= Currency.GetHashCode();
      if (timestamp_ != null) hash ^= Timestamp.GetHashCode();
      hash ^= AdditionalData.GetHashCode();
      if (SystemTradeId.Length != 0) hash ^= SystemTradeId.GetHashCode();
      if (UniqueTradeId.Length != 0) hash ^= UniqueTradeId.GetHashCode();
      if (Desk.Length != 0) hash ^= Desk.GetHashCode();
      if (ExchangeTradeId.Length != 0) hash ^= ExchangeTradeId.GetHashCode();
      if (MarketTrade != false) hash ^= MarketTrade.GetHashCode();
      if (AlgoId.Length != 0) hash ^= AlgoId.GetHashCode();
      if (Strategy.Length != 0) hash ^= Strategy.GetHashCode();
      if (Owner.Length != 0) hash ^= Owner.GetHashCode();
      if (ClearerAccount.Length != 0) hash ^= ClearerAccount.GetHashCode();
      if (Depot.Length != 0) hash ^= Depot.GetHashCode();
      if (Safekeeping.Length != 0) hash ^= Safekeeping.GetHashCode();
      if (Deleted != false) hash ^= Deleted.GetHashCode();
      if (FundingCurrency.Length != 0) hash ^= FundingCurrency.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (TradeId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TradeId);
      }
      if (ExchangeOrderId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ExchangeOrderId);
      }
      if (System.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(System);
      }
      if (Counterparty.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Counterparty);
      }
      if (PortfolioId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(PortfolioId);
      }
      if (Volume != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(Volume);
      }
      if (InstrumentId.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(InstrumentId);
      }
      if (Price != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(Price);
      }
      if (Currency.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(Currency);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Timestamp);
      }
      additionalData_.WriteTo(output, _map_additionalData_codec);
      if (SystemTradeId.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(SystemTradeId);
      }
      if (UniqueTradeId.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(UniqueTradeId);
      }
      if (Desk.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(Desk);
      }
      if (ExchangeTradeId.Length != 0) {
        output.WriteRawTag(130, 1);
        output.WriteString(ExchangeTradeId);
      }
      if (MarketTrade != false) {
        output.WriteRawTag(136, 1);
        output.WriteBool(MarketTrade);
      }
      if (AlgoId.Length != 0) {
        output.WriteRawTag(146, 1);
        output.WriteString(AlgoId);
      }
      if (Strategy.Length != 0) {
        output.WriteRawTag(154, 1);
        output.WriteString(Strategy);
      }
      if (Owner.Length != 0) {
        output.WriteRawTag(162, 1);
        output.WriteString(Owner);
      }
      if (ClearerAccount.Length != 0) {
        output.WriteRawTag(170, 1);
        output.WriteString(ClearerAccount);
      }
      if (Depot.Length != 0) {
        output.WriteRawTag(178, 1);
        output.WriteString(Depot);
      }
      if (Safekeeping.Length != 0) {
        output.WriteRawTag(186, 1);
        output.WriteString(Safekeeping);
      }
      if (Deleted != false) {
        output.WriteRawTag(192, 1);
        output.WriteBool(Deleted);
      }
      if (FundingCurrency.Length != 0) {
        output.WriteRawTag(202, 1);
        output.WriteString(FundingCurrency);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TradeId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TradeId);
      }
      if (ExchangeOrderId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ExchangeOrderId);
      }
      if (System.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(System);
      }
      if (Counterparty.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Counterparty);
      }
      if (PortfolioId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PortfolioId);
      }
      if (Volume != 0D) {
        size += 1 + 8;
      }
      if (InstrumentId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InstrumentId);
      }
      if (Price != 0D) {
        size += 1 + 8;
      }
      if (Currency.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Currency);
      }
      if (timestamp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Timestamp);
      }
      size += additionalData_.CalculateSize(_map_additionalData_codec);
      if (SystemTradeId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SystemTradeId);
      }
      if (UniqueTradeId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UniqueTradeId);
      }
      if (Desk.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Desk);
      }
      if (ExchangeTradeId.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ExchangeTradeId);
      }
      if (MarketTrade != false) {
        size += 2 + 1;
      }
      if (AlgoId.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(AlgoId);
      }
      if (Strategy.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Strategy);
      }
      if (Owner.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Owner);
      }
      if (ClearerAccount.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(ClearerAccount);
      }
      if (Depot.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Depot);
      }
      if (Safekeeping.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Safekeeping);
      }
      if (Deleted != false) {
        size += 2 + 1;
      }
      if (FundingCurrency.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(FundingCurrency);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TradeBookedMT other) {
      if (other == null) {
        return;
      }
      if (other.TradeId.Length != 0) {
        TradeId = other.TradeId;
      }
      if (other.ExchangeOrderId.Length != 0) {
        ExchangeOrderId = other.ExchangeOrderId;
      }
      if (other.System.Length != 0) {
        System = other.System;
      }
      if (other.Counterparty.Length != 0) {
        Counterparty = other.Counterparty;
      }
      if (other.PortfolioId.Length != 0) {
        PortfolioId = other.PortfolioId;
      }
      if (other.Volume != 0D) {
        Volume = other.Volume;
      }
      if (other.InstrumentId.Length != 0) {
        InstrumentId = other.InstrumentId;
      }
      if (other.Price != 0D) {
        Price = other.Price;
      }
      if (other.Currency.Length != 0) {
        Currency = other.Currency;
      }
      if (other.timestamp_ != null) {
        if (timestamp_ == null) {
          Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Timestamp.MergeFrom(other.Timestamp);
      }
      additionalData_.Add(other.additionalData_);
      if (other.SystemTradeId.Length != 0) {
        SystemTradeId = other.SystemTradeId;
      }
      if (other.UniqueTradeId.Length != 0) {
        UniqueTradeId = other.UniqueTradeId;
      }
      if (other.Desk.Length != 0) {
        Desk = other.Desk;
      }
      if (other.ExchangeTradeId.Length != 0) {
        ExchangeTradeId = other.ExchangeTradeId;
      }
      if (other.MarketTrade != false) {
        MarketTrade = other.MarketTrade;
      }
      if (other.AlgoId.Length != 0) {
        AlgoId = other.AlgoId;
      }
      if (other.Strategy.Length != 0) {
        Strategy = other.Strategy;
      }
      if (other.Owner.Length != 0) {
        Owner = other.Owner;
      }
      if (other.ClearerAccount.Length != 0) {
        ClearerAccount = other.ClearerAccount;
      }
      if (other.Depot.Length != 0) {
        Depot = other.Depot;
      }
      if (other.Safekeeping.Length != 0) {
        Safekeeping = other.Safekeeping;
      }
      if (other.Deleted != false) {
        Deleted = other.Deleted;
      }
      if (other.FundingCurrency.Length != 0) {
        FundingCurrency = other.FundingCurrency;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            TradeId = input.ReadString();
            break;
          }
          case 18: {
            ExchangeOrderId = input.ReadString();
            break;
          }
          case 26: {
            System = input.ReadString();
            break;
          }
          case 34: {
            Counterparty = input.ReadString();
            break;
          }
          case 42: {
            PortfolioId = input.ReadString();
            break;
          }
          case 57: {
            Volume = input.ReadDouble();
            break;
          }
          case 66: {
            InstrumentId = input.ReadString();
            break;
          }
          case 73: {
            Price = input.ReadDouble();
            break;
          }
          case 82: {
            Currency = input.ReadString();
            break;
          }
          case 90: {
            if (timestamp_ == null) {
              Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Timestamp);
            break;
          }
          case 98: {
            additionalData_.AddEntriesFrom(input, _map_additionalData_codec);
            break;
          }
          case 106: {
            SystemTradeId = input.ReadString();
            break;
          }
          case 114: {
            UniqueTradeId = input.ReadString();
            break;
          }
          case 122: {
            Desk = input.ReadString();
            break;
          }
          case 130: {
            ExchangeTradeId = input.ReadString();
            break;
          }
          case 136: {
            MarketTrade = input.ReadBool();
            break;
          }
          case 146: {
            AlgoId = input.ReadString();
            break;
          }
          case 154: {
            Strategy = input.ReadString();
            break;
          }
          case 162: {
            Owner = input.ReadString();
            break;
          }
          case 170: {
            ClearerAccount = input.ReadString();
            break;
          }
          case 178: {
            Depot = input.ReadString();
            break;
          }
          case 186: {
            Safekeeping = input.ReadString();
            break;
          }
          case 192: {
            Deleted = input.ReadBool();
            break;
          }
          case 202: {
            FundingCurrency = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code