namespace Redplcs.ChipEight.VirtualMachine.Core;

public interface IChipEightRegisterValueInstruction : IChipEightInstruction
{
	byte Register { get; }
	byte Value { get; }
}
