namespace Redplcs.ChipEight.VirtualMachine.Core.Tests;

public readonly struct ChipEightSkeInstruction : IChipEightRegisterValueInstruction
{
	public byte Register { get; }
	public byte Value { get; }

	public ChipEightMnemonic Mnemonic => ChipEightMnemonic.Ske;
}
