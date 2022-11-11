uint32_t FloatToUint(float n)
{
   return (uint32_t)(*(uint32_t*)&n);
}
 
float UintToFloat(uint32_t n)
{
   return (float)(*(float*)&n);
}
