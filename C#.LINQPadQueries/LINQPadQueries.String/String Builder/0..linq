<Query Kind="Program" />

public sealed class StringBuilder
	{
	    // Содержимое текущего блока
	    internal char[] m_ChunkChars;
	    // Предыдущий блок
	    internal StringBuilder m_ChunkPrevious;
	    // Количество символов в текущем блоке
	    internal int m_ChunkLength;
	    // Суммарный объем предыдущих блоков
	    internal int m_ChunkOffset;
	    // Нужно гарантировать непопадание массива символов в большую кучу
	    // (<85000 bytes ~ 40К символов).
	    // Слишком большой размер блока приведет к меньшему числу аллокаций, 
	    // но приведет к бесполезному расходу памяти за счет неиспользуемых символов,
	    // а также замедлит вставку/замену (поскольку это требует сдвиг всех символов
	    // внутри буффера).
	    internal const int MaxChunkSize = 8000;
	    // etc!
	}