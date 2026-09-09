const manifest = {
    type: 'propertyEditorSchema',
    name: 'Limbo Boolean',
    alias: 'Limbo.Umbraco.Boolean',
    meta: {
        defaultPropertyEditorUiAlias: 'Umb.PropertyEditorUi.Toggle',
        settings: {
            properties: [
                {
                    alias: 'default',
                    label: 'Initial state',
                    description: 'The initial state for properties without a saved value.',
                    propertyEditorUiAlias: 'Umb.PropertyEditorUi.Toggle'
                }
            ],
            defaultData: [
                {
                    alias: 'default',
                    value: false
                }
            ]
        }
    }
};

export const manifests = [manifest];
