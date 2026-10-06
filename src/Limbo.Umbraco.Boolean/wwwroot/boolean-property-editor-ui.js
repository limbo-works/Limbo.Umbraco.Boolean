import { html, css } from "@umbraco-cms/backoffice/external/lit";
import { UmbChangeEvent } from "@umbraco-cms/backoffice/event";
import { UmbLitElement } from "@umbraco-cms/backoffice/lit-element";
import { UmbFormControlMixin, UMB_VALIDATION_FALSE_LOCALIZATION_KEY } from "@umbraco-cms/backoffice/validation";

export default class LimboBooleanPropertyEditorUiElement extends UmbFormControlMixin(UmbLitElement) {

	static properties = {
		value: {},
		readonly: { type: Boolean }
	};

	static styles = css`
        uui-toggle {
            display: block;
        }
    `;

	name;
	readonly = false;
	mandatory;
	mandatoryMessage = UMB_VALIDATION_FALSE_LOCALIZATION_KEY;

	_ariaLabel;
	_labelOff;
	_labelOn;
	_showLabels = false;

	set config(config) {
		if (!config) return;
		this._default = Boolean(config.getValueByAlias("default"));
		this._showLabels = Boolean(config.getValueByAlias("showLabels"));
		this._labelOn = this.localize.string(config.getValueByAlias("labelOn") ?? "");
		this._labelOff = this.localize.string(config.getValueByAlias("labelOff") ?? "");
		this._ariaLabel =
			this.localize.string(config.getValueByAlias("ariaLabel")) ||
			this.localize.term("general_toggleFor", [this.name]);
	}

	connectedCallback() {
		super.connectedCallback();
		if (this.value === "0") {
			this.value = false;
		} else if (this.value === "1") {
			this.value = true;
		} else if (this.value === undefined) {
			this.value = this._default;
		}
	}

	firstUpdated() {
		this.addFormControlElement(this.shadowRoot.querySelector("umb-input-toggle"));
	}

	#onChange(event) {
		this.value = event.target.checked;
		this.dispatchEvent(new UmbChangeEvent());
	}

	render() {
		return html`
			<umb-input-toggle
				.ariaLabel=${this._ariaLabel ?? null}
				.labelOn=${this._labelOn}
				.labelOff=${this._labelOff}
				.requiredMessage=${this.mandatoryMessage}
				.showLabels=${this._showLabels}
				?checked=${this.value}
				?readonly=${this.readonly}
				?required=${this.mandatory}
				@change=${this.#onChange}>
			</umb-input-toggle>
		`;
	}

}

customElements.define("limbo-boolean-property-editor-ui", LimboBooleanPropertyEditorUiElement);