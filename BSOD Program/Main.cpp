#include "bsod.h"
#include <iostream>
#include <string>
#include <Windows.h>

#pragma comment(lib, "ntdll.lib")


using namespace std;

/*Copied from:
*
*https://stackoverflow.com/questions/49207263/c-sharp-how-to-p-invoke-ntraiseharderror
*
*This is not a exploit, just a undocumented feature.
*
*/
EXTERN_C NTSTATUS NTAPI RtlAdjustPrivilege(ULONG, BOOLEAN, BOOLEAN, PBOOLEAN);

EXTERN_C NTSTATUS NTAPI NtRaiseHardError(NTSTATUS, ULONG, ULONG, PULONG_PTR, ULONG, PULONG);

int main(int argc, char **argv)
{
	BOOLEAN bl;
	RtlAdjustPrivilege(19, TRUE, FALSE, &bl);
	unsigned long response;
	NtRaiseHardError(STATUS_ASSERTION_FAILURE, 0, 0, 0, 6, &response);
	return 0;
}
