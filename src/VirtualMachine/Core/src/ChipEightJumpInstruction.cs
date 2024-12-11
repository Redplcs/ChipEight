namespace Redplcs.ChipEight.VirtualMachine.Core;

public readonly struct ChipEightJumpInstruction : IChipEightAddressInstruction
{
	public int Address { get; init; }

	public ChipEightMnemonic Mnemonic => ChipEightMnemonic.Jump;
}
