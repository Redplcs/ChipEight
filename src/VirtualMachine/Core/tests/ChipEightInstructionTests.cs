namespace Redplcs.ChipEight.VirtualMachine.Core.Tests;

public abstract class ChipEightInstructionTests<TInstruction> where TInstruction : struct, IChipEightInstruction
{
	[Fact]
	public void Mnemonic_Always_Correct()
	{
		var expectedMnemonic = GetMnemonic();
		var instruction = new TInstruction();

		var actualMnemonic = instruction.Mnemonic;

		Assert.Equal(expectedMnemonic, actualMnemonic);
	}

	private static ChipEightMnemonic GetMnemonic()
	{
		var instruction = new TInstruction();

		return instruction switch
		{
			ChipEightSysInstruction => ChipEightMnemonic.Sys,
			ChipEightClrInstruction => ChipEightMnemonic.Clr,
			ChipEightRtsInstruction => ChipEightMnemonic.Rts,
			ChipEightJumpInstruction => ChipEightMnemonic.Jump,
			ChipEightCallInstruction => ChipEightMnemonic.Call,
			ChipEightSkeInstruction => ChipEightMnemonic.Ske,
			_ => throw new InvalidOperationException("The instruction is unknown")
		};
	}
}
