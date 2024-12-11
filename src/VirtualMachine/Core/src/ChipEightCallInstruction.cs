namespace Redplcs.ChipEight.VirtualMachine.Core;

public readonly struct ChipEightCallInstruction : IChipEightAddressInstruction
{
	public int Address { get; init; }

	public ChipEightMnemonic Mnemonic => ChipEightMnemonic.Call;
}
