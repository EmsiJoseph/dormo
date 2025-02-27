export const formatCurrency = (amount: number): string => 
    new Intl.NumberFormat('en-PH', { 
        style: 'currency', 
        currency: 'PHP',
        minimumFractionDigits: 0,
        maximumFractionDigits: 0,
    }).format(amount);

export const parseCurrency = (value: string): number => {
    const normalized = value.replace(/[^0-9.]/g, '');
    return parseFloat(normalized) || 0;
};
